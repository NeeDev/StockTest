using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Contract.View;
using Stock.Contract.Model;
using Stock.Contract.Presenter;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock.Presenter
{
    class MainPresenter : IMainPresenter
    {
        IMainView view;
        IMainModel model;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }

        public void Init()
        {
            //using System.Windows.Forms;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            //using System.Data.SqlClient;
            SqlDataReader reader = DBHelper.Instance.Command("Select * From KOSPI");

            while(reader.Read())
            { 
               coll.Add(reader["company"].ToString() + " (" + reader["code"].ToString() + ")");
            }
            view.setTextBoxAuto(coll);

        }
    }
}
