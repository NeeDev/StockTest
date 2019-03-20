using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Contract.Model;

namespace Stock.Model
{
    class AccountModel : IAccountModel
    {
        public static string USER_ID      = "USER_ID";
        public static string USER_NAME    = "USER_NAME";
        public static string USER_ACCLIST = "ACCLIST";

        AxKHOpenAPILib.AxKHOpenAPI KHOpenAPI;

        public AccountModel()
        {
            KHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            KHOpenAPI.CreateControl();      
        }

        public string getData(string fid)
        {
            return KHOpenAPI.GetLoginInfo(fid);
        }
    }
}
