﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            KH_OpenAPI.CommConnect();
            KH_OpenAPI.OnEventConnect += E_Connect;
           
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
