namespace Ki_WAT
{
    partial class Frm_Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mainfrm));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.BtnCal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_T = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.BtnParam = new System.Windows.Forms.Button();
            this.btnIo = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnManual = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNavBar.Controls.Add(this.BtnCal);
            this.panelNavBar.Controls.Add(this.button1);
            this.panelNavBar.Controls.Add(this.Btn_T);
            this.panelNavBar.Controls.Add(this.pictureBox1);
            this.panelNavBar.Controls.Add(this.picLogo);
            this.panelNavBar.Controls.Add(this.BtnParam);
            this.panelNavBar.Controls.Add(this.btnIo);
            this.panelNavBar.Controls.Add(this.BtnConfig);
            this.panelNavBar.Controls.Add(this.BtnManual);
            this.panelNavBar.Controls.Add(this.BtnMain);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(91, 1011);
            this.panelNavBar.TabIndex = 6;
            // 
            // BtnCal
            // 
            this.BtnCal.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCal.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnCal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCal.Location = new System.Drawing.Point(4, 237);
            this.BtnCal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(83, 60);
            this.BtnCal.TabIndex = 553;
            this.BtnCal.Tag = "frmParameter";
            this.BtnCal.Text = "Cal";
            this.BtnCal.UseVisualStyleBackColor = false;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(4, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 60);
            this.button1.TabIndex = 552;
            this.button1.Tag = "frmSetting";
            this.button1.Text = "Langu  age";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_T
            // 
            this.Btn_T.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_T.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_T.Font = new System.Drawing.Font("Verdana", 12F);
            this.Btn_T.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_T.Location = new System.Drawing.Point(4, 816);
            this.Btn_T.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_T.Name = "Btn_T";
            this.Btn_T.Size = new System.Drawing.Size(83, 60);
            this.Btn_T.TabIndex = 551;
            this.Btn_T.Tag = "frmSetting";
            this.Btn_T.Text = "TT";
            this.Btn_T.UseVisualStyleBackColor = false;
            this.Btn_T.Click += new System.EventHandler(this.Btn_T_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 901);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 550;
            this.pictureBox1.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(66, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 549;
            this.picLogo.TabStop = false;
            // 
            // BtnParam
            // 
            this.BtnParam.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnParam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParam.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnParam.Location = new System.Drawing.Point(5, 166);
            this.BtnParam.Margin = new System.Windows.Forms.Padding(4);
            this.BtnParam.Name = "BtnParam";
            this.BtnParam.Size = new System.Drawing.Size(83, 60);
            this.BtnParam.TabIndex = 95;
            this.BtnParam.Tag = "frmParameter";
            this.BtnParam.Text = "Param";
            this.BtnParam.UseVisualStyleBackColor = false;
            this.BtnParam.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // btnIo
            // 
            this.btnIo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIo.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnIo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIo.Location = new System.Drawing.Point(4, 379);
            this.btnIo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIo.Name = "btnIo";
            this.btnIo.Size = new System.Drawing.Size(83, 60);
            this.btnIo.TabIndex = 94;
            this.btnIo.Tag = "frmIo";
            this.btnIo.Text = "Digital I/O";
            this.btnIo.UseVisualStyleBackColor = false;
            this.btnIo.Click += new System.EventHandler(this.btnIo_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfig.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConfig.Location = new System.Drawing.Point(4, 450);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(83, 60);
            this.BtnConfig.TabIndex = 7;
            this.BtnConfig.Tag = "frmSetting";
            this.BtnConfig.Text = "Config";
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnManual
            // 
            this.BtnManual.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnManual.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnManual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnManual.Location = new System.Drawing.Point(4, 308);
            this.BtnManual.Margin = new System.Windows.Forms.Padding(4);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(83, 60);
            this.BtnManual.TabIndex = 4;
            this.BtnManual.Tag = "frmManual";
            this.BtnManual.Text = "Manual";
            this.BtnManual.UseVisualStyleBackColor = false;
            this.BtnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // BtnMain
            // 
            this.BtnMain.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMain.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMain.Location = new System.Drawing.Point(5, 95);
            this.BtnMain.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(83, 60);
            this.BtnMain.TabIndex = 2;
            this.BtnMain.Tag = "frmMain";
            this.BtnMain.Text = "Main";
            this.BtnMain.UseVisualStyleBackColor = false;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // Frm_Mainfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.panelNavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parallelism";
            this.Load += new System.EventHandler(this.Frm_Mainfrm_Load);
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button BtnParam;
        private System.Windows.Forms.Button btnIo;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Button BtnManual;
        private System.Windows.Forms.Button BtnMain;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_T;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCal;
    }
}

