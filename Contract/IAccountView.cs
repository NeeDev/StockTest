using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Contract
{
    interface IAccountView
    {
        void ShowUserName();   // 사용자 이름
        void ShowUserID();     // 사용자 아이디
        void ShowAccList();    // 사용자 계좌리스트
    }
}
