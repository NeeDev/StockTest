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
            this.tbSearchStock = new System.Windows.Forms.TextBox();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.KH_OpenAPI)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KH_OpenAPI
            // 
            this.KH_OpenAPI.Enabled = true;
            this.KH_OpenAPI.Location = new System.Drawing.Point(11, 253);
            this.KH_OpenAPI.Name = "KH_OpenAPI";
            this.KH_OpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KH_OpenAPI.OcxState")));
            this.KH_OpenAPI.Size = new System.Drawing.Size(52, 23);
            this.KH_OpenAPI.TabIndex = 0;
            this.KH_OpenAPI.Visible = false;
            // 
            // tbSearchStock
            // 
            this.tbSearchStock.Location = new System.Drawing.Point(12, 118);
            this.tbSearchStock.Name = "tbSearchStock";
            this.tbSearchStock.Size = new System.Drawing.Size(200, 21);
            this.tbSearchStock.TabIndex = 1;
            // 
            // panelAccount
            // 
            this.panelAccount.Location = new System.Drawing.Point(12, 12);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(200, 100);
            this.panelAccount.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.KH_OpenAPI);
            this.panelMenu.Location = new System.Drawing.Point(12, 145);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 524);
            this.panelMenu.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(218, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1034, 656);
            this.panel.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.tbSearchStock);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainView";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.KH_OpenAPI)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI KH_OpenAPI;
        private System.Windows.Forms.TextBox tbSearchStock;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel;
    }
}

