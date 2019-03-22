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
            Init();
        }

        public void Init()
        {
            view.KH_OpenAPI.CommConnect();
            view.KH_OpenAPI.OnEventConnect += KH_Connect;


            #region # TextBox Setting
            view.t_searchStock.KeyDown += textBox_Keydown;
            

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader reader = DBHelper.Instance.Command("select company from KOSPI");

            while (reader.Read())
            {
                // trim이 없으면 공백이 생김..............
                string company = reader["company"].ToString().Trim();
                coll.Add(company);
            }

            view.t_searchStock.AutoCompleteMode = AutoCompleteMode.Suggest;
            view.t_searchStock.AutoCompleteSource = AutoCompleteSource.CustomSource;
            view.t_searchStock.AutoCompleteCustomSource = coll;
            #endregion

        }

        private void KH_Connect(Object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            switch (e.nErrCode)
            {
                case KHErrorCode.NONE:
                    break;
                case KHErrorCode.USERINFO:
                    break;
                case KHErrorCode.SERVER:
                    break;
                default:
                    break;
            }
        }

        private void textBox_Keydown(Object obj, KeyEventArgs e)
        {
            TextBox tb = (TextBox)obj;
            
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show(tb.Text);
        }
    }
}
