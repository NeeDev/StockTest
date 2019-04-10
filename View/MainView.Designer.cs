namespace Stock
{
    partial class MainView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.KH_OpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnMain = new Stock.CustomPanel();
            this.userControl11 = new StockInformationView.UserControl1();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.tbSearchStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KH_OpenAPI)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.SuspendLayout();
            // 
            // KH_OpenAPI
            // 
            this.KH_OpenAPI.Enabled = true;
            this.KH_OpenAPI.Location = new System.Drawing.Point(12, 646);
            this.KH_OpenAPI.Name = "KH_OpenAPI";
            this.KH_OpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KH_OpenAPI.OcxState")));
            this.KH_OpenAPI.Size = new System.Drawing.Size(52, 23);
            this.KH_OpenAPI.TabIndex = 0;
            this.KH_OpenAPI.Visible = false;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(13)))), ((int)(((byte)(25)))));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMenu.Controls.Add(this.button6);
            this.pnMenu.Controls.Add(this.button5);
            this.pnMenu.Controls.Add(this.button3);
            this.pnMenu.Controls.Add(this.button4);
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.KH_OpenAPI);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 720);
            this.pnMenu.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(15, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(15, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(15, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnMain.Controls.Add(this.userControl11);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.tbSearchStock);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1080, 720);
            this.pnMain.TabIndex = 7;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 100);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1080, 620);
            this.userControl11.TabIndex = 8;
            // 
            // btClose
            // 
            this.btClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btClose.InitialImage")));
            this.btClose.Location = new System.Drawing.Point(1020, 34);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 25, 25, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(26, 26);
            this.btClose.TabIndex = 7;
            this.btClose.TabStop = false;
            // 
            // tbSearchStock
            // 
            this.tbSearchStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbSearchStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchStock.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearchStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchStock.Location = new System.Drawing.Point(25, 35);
            this.tbSearchStock.Margin = new System.Windows.Forms.Padding(25, 25, 3, 3);
            this.tbSearchStock.Name = "tbSearchStock";
            this.tbSearchStock.Size = new System.Drawing.Size(100, 25);
            this.tbSearchStock.TabIndex = 6;
            this.tbSearchStock.Text = "Search..";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.KH_OpenAPI)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxKHOpenAPILib.AxKHOpenAPI KH_OpenAPI;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchStock;
        private System.Windows.Forms.PictureBox btClose;
        private CustomPanel pnMain;
        private StockInformationView.UserControl1 userControl11;
    }
}

