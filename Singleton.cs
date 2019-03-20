using System;
using System.Reflection;

public class Singleton<T> where T : class
{
    private static object syncobj = new object();
    private static volatile T instace = null;

    public static T Instance
    {
        get
        {
            if (instace == null)
            {
                CreateInstance();
            }
            return instace;
        }
    }

    private static void CreateInstance()
    {
        lock (syncobj)
        {
            if (instace == null)
            {
                Type t = typeof(T);

                // public constructors..가 있나 확인.
                // ConstructorInfo는 클래스 생성자 특성을 검색하고 생성자 메타 데이터에 대한 액세스를 제공.
                ConstructorInfo[] ctors = t.GetConstructors();
               
                if (ctors.Length > 0)
                {
                    // 한개 이상 존재 시 exeption 발생.
                    throw new InvalidOperationException(String.Format("{0} has at least one accesible ctor making it impossible to enforce singleton behaviour", t.Name));
                }

                //using System에서 지원 Activator는 해당 타입의 인스턴스를 동적으로!! 생성할 수 있게 도와준다.
                instace = (T)Activator.CreateInstance(t, true);
            }
        }
    }
}