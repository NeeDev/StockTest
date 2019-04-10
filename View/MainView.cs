using Stock.Contract.View;
using Stock.Contract.Presenter;
using System;
using System.Diagnostics;
using Stock.Presenter;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AxKHOpenAPILib;
using System.Drawing;

namespace Stock
{
    public partial class MainView : Form, IMainView
    {
        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        #region # Define Property
        MainPresenter presenter;


        TextBox IMainView.tbSearchStock
        {
            get { return this.tbSearchStock; }
        }
        PictureBox IMainView.btClose
        {
            get { return this.btClose; }
        }
        AxKHOpenAPI IMainView.KH_OpenAPI
        {
            get { return this.KH_OpenAPI; }
        }
        #endregion

        public MainView()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            Init();

        }
     
        void Init()
        {

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.Opaque, true);

            //pnMain.ForeColor = Color.FromArgb(20, 30, 30, 30);
            //pnMain.BackColor = Color.FromArgb(20, 30, 30, 30);
            //pnMain.BackColor = Color.FromArgb(20, 30, 30, 30);
        }
        
    }
    
    public class CustomPanel : Panel
    {
        public CustomPanel()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }

}
