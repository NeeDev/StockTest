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
        
        public DBHelper ()
        {
            scon = new SqlConnection(SCON_STRING);
            scom = new SqlCommand();

            scom.Connection = scon;
        }  

        public SqlDataReader Command(string comm)
        {
            scom.CommandText = comm;
            return scom.ExecuteReader();
        }
        
    }
}
