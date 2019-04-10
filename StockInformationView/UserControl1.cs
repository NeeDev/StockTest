using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace StockInformationView
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Init();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 컨트롤의 세로 길이
            // 그래디언트 색깔 
            Graphics graphicsObject = e.Graphics;
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 0),
               new Point(0, this.Height),
               Color.FromArgb(255, 250, 99, 109),   // Opaque red
               Color.FromArgb(255, 0, 50, 250)
            );  // Opaque blue
            Pen pen = new Pen(linGrBrush,10);
            this.CreateGraphics().DrawLine(pen, 0, 0, 0, this.Height);
        }
        void Init()
        {
           
            Graphics graphics = this.CreateGraphics();

           
            
        }
    }
}
