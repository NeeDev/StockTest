using Stock.Contract.View;
using Stock.Contract.Presenter;
using System;
using System.Diagnostics;
using Stock.Presenter;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Stock
{
    public partial class MainView : Form, IMainView
    {
        MainPresenter presenter;

        public MainView()
        {
            
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            KH_OpenAPI.CommConnect();
            KH_OpenAPI.OnEventConnect += E_Connect;

            //presenter = new AccountPresenter(this);
            presenter = new MainPresenter(this);
        }

        public void E_Connect(Object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            switch(e.nErrCode)
            {
                case KHErrorCode.NONE:
                    presenter.getAccountInfo();
                    break;
                case KHErrorCode.USERINFO:
                    presenter.getAccountInfo();
                    break;
                case KHErrorCode.SERVER:
                    break;
                default:
                    break;
            }
        }

        public void DisplayUserName(string name)
        {
            Debug.WriteLine(name);
        }

        public void DisplayUserID(string name)
        {
            Debug.WriteLine(name);
        }

        public void DisplayAccList(string name)
        {
            Debug.WriteLine(name);
        }
    }
}
