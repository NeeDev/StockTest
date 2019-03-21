using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock
{
    class DBHelper : Singleton<DBHelper>
    {
        const string SCON_STRING = "server=localhost;uid=sa;pwd=asd123;database=STOCK;";
       
        SqlConnection scon;
        SqlCommand scom;
        

        public SqlDataReader Command(string comm)
        {
            scon = new SqlConnection(SCON_STRING);
            scom = new SqlCommand();
            scom.Connection = scon;
            scom.CommandText = comm;
            using 
            {
                scon.open();

            }
            return scom.ExecuteReader();
        }
    }
}
