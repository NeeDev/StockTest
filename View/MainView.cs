using Stock.Contract.View;
using Stock.Contract.Presenter;
using System;
using System.Diagnostics;
using Stock.Presenter;
using System.Windows.Forms;
using AxKHOpenAPILib;

namespace Stock
{
    public partial class MainView : Form, IMainView
    {
        #region # Define Property
        MainPresenter presenter;
        TextBox IMainView.tbSearchStock
        {
            get { return this.tbSearchStock; }
        }

        AxKHOpenAPI IMainView.KH_OpenAPI
        {
            get{ return this.KH_OpenAPI; }
        }
        #endregion

        public MainView()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

    }
}
