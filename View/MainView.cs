using Stock.Contract;
using System;
using System.Windows.Forms;
namespace Stock
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            //KH_OpenAPI.CommConnect();        
        }

        public void E_Connect(Object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            switch(e.nErrCode)
            {
                case KHErrorCode.NONE:
                    KH_OpenAPI.GetLoginInfo("USER_NAME");
                    break;
                case KHErrorCode.USERINFO:
                    break;
                case KHErrorCode.SERVER:
                    break;
                default:
                    break;
            }
        }
    }
}
