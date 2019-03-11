using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class KHErrorCode
    {
        public const int NONE      = 0;    //에러 없음
        public const int USERINFO  = -100; 
        public const int SERVER    = -101; //로그인 실패 - 서버와 연결 종료
    }
}
