using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Contract;

namespace Stock.Contract.Model
{
    interface IAccountModel
    {
        string getData(string data);  // 원하는 데이터 얻기.
     
    }
}
