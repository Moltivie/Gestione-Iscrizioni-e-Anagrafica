namespace Gestione_Iscrizioni_e_Anagrafica {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.DragControllogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelDragControl = new System.Windows.Forms.Panel();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.textboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textboxUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblForgetPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLog = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAccess = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBoxLoginPng = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControllogin
            // 
            this.DragControllogin.Fixed = true;
            this.DragControllogin.Horizontal = true;
            this.DragControllogin.TargetControl = this.panelDragControl;
            this.DragControllogin.Vertical = true;
            // 
            // panelDragControl
            // 
            this.panelDragControl.BackColor = System.Drawing.Color.Transparent;
            this.panelDragControl.Location = new System.Drawing.Point(0, 0);
            this.panelDragControl.Name = "panelDragControl";
            this.panelDragControl.Size = new System.Drawing.Size(347, 37);
            this.panelDragControl.TabIndex = 8;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuGradientPanel
            // 
            this.bunifuGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel.BackgroundImage")));
            this.bunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel.Controls.Add(this.button2);
            this.bunifuGradientPanel.Controls.Add(this.button1);
            this.bunifuGradientPanel.Controls.Add(this.panelDragControl);
            this.bunifuGradientPanel.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel.Controls.Add(this.lblCopyright);
            this.bunifuGradientPanel.Controls.Add(this.textboxPassword);
            this.bunifuGradientPanel.Controls.Add(this.textboxUsername);
            this.bunifuGradientPanel.Controls.Add(this.lblForgetPassword);
            this.bunifuGradientPanel.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel.Controls.Add(this.lblLog);
            this.bunifuGradientPanel.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel.Controls.Add(this.lblAccess);
            this.bunifuGradientPanel.Controls.Add(this.pictureBoxLoginPng);
            this.bunifuGradientPanel.Controls.Add(this.btnClose);
            this.bunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel.Name = "bunifuGradientPanel";
            this.bunifuGradientPanel.Quality = 10;
            this.bunifuGradientPanel.Size = new System.Drawing.Size(389, 585);
            this.bunifuGradientPanel.TabIndex = 2;
            this.bunifuGradientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "GetHashOfPassword";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Accedi";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Location = new System.Drawing.Point(102, 431);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(161, 40);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCopyright.Location = new System.Drawing.Point(274, 560);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(103, 16);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "© 2018 Aiman, Inc";
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textboxPassword.BorderColorFocused = System.Drawing.Color.Transparent;
            this.textboxPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPassword.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.textboxPassword.BorderThickness = 1;
            this.textboxPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPassword.isPassword = true;
            this.textboxPassword.Location = new System.Drawing.Point(46, 354);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textboxPassword.MaxLength = 32767;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(282, 36);
            this.textboxPassword.TabIndex = 1;
            this.textboxPassword.Tag = "";
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.textboxUsername.BorderColorFocused = System.Drawing.Color.Transparent;
            this.textboxUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxUsername.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.textboxUsername.BorderThickness = 1;
            this.textboxUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxUsername.isPassword = false;
            this.textboxUsername.Location = new System.Drawing.Point(46, 243);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textboxUsername.MaxLength = 32767;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(282, 36);
            this.textboxUsername.TabIndex = 0;
            this.textboxUsername.Tag = "";
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblForgetPassword.Location = new System.Drawing.Point(118, 491);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(136, 16);
            this.lblForgetPassword.TabIndex = 3;
            this.lblForgetPassword.Text = "Password dimenticata?";
            this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 315);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLog.Location = new System.Drawing.Point(81, 529);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 20);
            this.lblLog.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 205);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 22);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.BackColor = System.Drawing.Color.Transparent;
            this.lblAccess.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccess.Location = new System.Drawing.Point(133, 111);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(219, 30);
            this.lblAccess.TabIndex = 4;
            this.lblAccess.Text = "Accedi al Portale";
            // 
            // pictureBoxLoginPng
            // 
            this.pictureBoxLoginPng.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginPng.Image = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngAccess;
            this.pictureBoxLoginPng.Location = new System.Drawing.Point(46, 96);
            this.pictureBoxLoginPng.Name = "pictureBoxLoginPng";
            this.pictureBoxLoginPng.Size = new System.Drawing.Size(69, 61);
            this.pictureBoxLoginPng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoginPng.TabIndex = 3;
            this.pictureBoxLoginPng.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(346, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "GetHashOfPassword";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 585);
            this.Controls.Add(this.bunifuGradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bunifuGradientPanel.ResumeLayout(false);
            this.bunifuGradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragControllogin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel;
        private System.Windows.Forms.PictureBox pictureBoxLoginPng;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAccess;
        private Bunifu.Framework.UI.BunifuMetroTextbox textboxUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox textboxPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label lblCopyright;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panelDragControl;
        private Bunifu.Framework.UI.BunifuCustomLabel lblForgetPassword;
        private System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblLog;
        private System.Windows.Forms.Button button2;
    }
}

