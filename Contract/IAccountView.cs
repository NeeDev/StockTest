using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Contract
{
    interface IAccountView
    {
        void DisplayUserName(string name);   // 사용자 이름
        void DisplayUserID(string id);     // 사용자 아이디
        void DisplayAccList(string acclist);    // 사용자 계좌리스트
    }
}
