namespace Gestione_Iscrizioni_e_Anagrafica
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelDragControl = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAbout = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLayout = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnReduceIconsClone = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnReduceIcons = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEsci = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnagrafiche = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImpostazioni = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEventi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelDragControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceIconsClone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceIcons)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelDragControl;
            this.bunifuDragControl.Vertical = true;
            // 
            // panelDragControl
            // 
            this.panelDragControl.BackColor = System.Drawing.Color.Transparent;
            this.panelDragControl.Controls.Add(this.lblTitle);
            this.panelDragControl.Controls.Add(this.btnAbout);
            this.panelDragControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDragControl.Location = new System.Drawing.Point(0, 0);
            this.panelDragControl.Name = "panelDragControl";
            this.panelDragControl.Size = new System.Drawing.Size(685, 32);
            this.panelDragControl.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestione Iscrizioni e Anagrafiche";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageActive = null;
            this.btnAbout.Location = new System.Drawing.Point(651, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(34, 32);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbout.TabIndex = 3;
            this.btnAbout.TabStop = false;
            this.btnAbout.Zoom = 10;
            this.btnAbout.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panelHome);
            this.bunifuGradientPanel1.Controls.Add(this.panelMenu);
            this.bunifuGradientPanel1.Controls.Add(this.panelDragControl);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(685, 451);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHome.Controls.Add(this.lblCopyright);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(172, 32);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(513, 419);
            this.panelHome.TabIndex = 12;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCopyright.Location = new System.Drawing.Point(404, 397);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(103, 16);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "© 2018 Aiman, Inc";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panelLayout);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.btnReduceIconsClone);
            this.panelMenu.Controls.Add(this.btnReduceIcons);
            this.panelMenu.Controls.Add(this.btnEsci);
            this.panelMenu.Controls.Add(this.btnAnagrafiche);
            this.panelMenu.Controls.Add(this.btnImpostazioni);
            this.panelMenu.Controls.Add(this.btnEventi);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 419);
            this.panelMenu.TabIndex = 11;
            // 
            // panelLayout
            // 
            this.panelLayout.BackColor = System.Drawing.Color.White;
            this.panelLayout.Location = new System.Drawing.Point(0, 94);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(5, 54);
            this.panelLayout.TabIndex = 11;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(95, 65);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnReduceIconsClone
            // 
            this.btnReduceIconsClone.Image = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngHamburgerMenu;
            this.btnReduceIconsClone.ImageActive = null;
            this.btnReduceIconsClone.Location = new System.Drawing.Point(15, 12);
            this.btnReduceIconsClone.Margin = new System.Windows.Forms.Padding(2);
            this.btnReduceIconsClone.Name = "btnReduceIconsClone";
            this.btnReduceIconsClone.Size = new System.Drawing.Size(26, 27);
            this.btnReduceIconsClone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReduceIconsClone.TabIndex = 1;
            this.btnReduceIconsClone.TabStop = false;
            this.btnReduceIconsClone.Visible = false;
            this.btnReduceIconsClone.Zoom = 10;
            this.btnReduceIconsClone.Click += new System.EventHandler(this.btnReduceIcons_Click);
            // 
            // btnReduceIcons
            // 
            this.btnReduceIcons.Image = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngHamburgerMenu;
            this.btnReduceIcons.ImageActive = null;
            this.btnReduceIcons.Location = new System.Drawing.Point(132, 12);
            this.btnReduceIcons.Margin = new System.Windows.Forms.Padding(2);
            this.btnReduceIcons.Name = "btnReduceIcons";
            this.btnReduceIcons.Size = new System.Drawing.Size(37, 27);
            this.btnReduceIcons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReduceIcons.TabIndex = 1;
            this.btnReduceIcons.TabStop = false;
            this.btnReduceIcons.Zoom = 10;
            this.btnReduceIcons.Click += new System.EventHandler(this.btnReduceIcons_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Active = false;
            this.btnEsci.Activecolor = System.Drawing.Color.Transparent;
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEsci.BackColor = System.Drawing.Color.Transparent;
            this.btnEsci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsci.BorderRadius = 0;
            this.btnEsci.ButtonText = "Esci";
            this.btnEsci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsci.DisabledColor = System.Drawing.Color.Gray;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEsci.Iconimage = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngUscita;
            this.btnEsci.Iconimage_right = null;
            this.btnEsci.Iconimage_right_Selected = null;
            this.btnEsci.Iconimage_Selected = null;
            this.btnEsci.IconMarginLeft = 0;
            this.btnEsci.IconMarginRight = 0;
            this.btnEsci.IconRightVisible = true;
            this.btnEsci.IconRightZoom = 0D;
            this.btnEsci.IconVisible = true;
            this.btnEsci.IconZoom = 35D;
            this.btnEsci.IsTab = false;
            this.btnEsci.Location = new System.Drawing.Point(0, 363);
            this.btnEsci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEsci.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEsci.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEsci.selected = false;
            this.btnEsci.Size = new System.Drawing.Size(172, 54);
            this.btnEsci.TabIndex = 0;
            this.btnEsci.Text = "Esci";
            this.btnEsci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEsci.Textcolor = System.Drawing.Color.White;
            this.btnEsci.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnAnagrafiche
            // 
            this.btnAnagrafiche.Active = false;
            this.btnAnagrafiche.Activecolor = System.Drawing.Color.Transparent;
            this.btnAnagrafiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnagrafiche.BackColor = System.Drawing.Color.Transparent;
            this.btnAnagrafiche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnagrafiche.BorderRadius = 0;
            this.btnAnagrafiche.ButtonText = "Anagrafiche";
            this.btnAnagrafiche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnagrafiche.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnagrafiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnagrafiche.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnagrafiche.Iconimage = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngAnagrafica;
            this.btnAnagrafiche.Iconimage_right = null;
            this.btnAnagrafiche.Iconimage_right_Selected = null;
            this.btnAnagrafiche.Iconimage_Selected = null;
            this.btnAnagrafiche.IconMarginLeft = 0;
            this.btnAnagrafiche.IconMarginRight = 0;
            this.btnAnagrafiche.IconRightVisible = true;
            this.btnAnagrafiche.IconRightZoom = 0D;
            this.btnAnagrafiche.IconVisible = true;
            this.btnAnagrafiche.IconZoom = 35D;
            this.btnAnagrafiche.IsTab = false;
            this.btnAnagrafiche.Location = new System.Drawing.Point(5, 202);
            this.btnAnagrafiche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnagrafiche.Name = "btnAnagrafiche";
            this.btnAnagrafiche.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAnagrafiche.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAnagrafiche.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnagrafiche.selected = false;
            this.btnAnagrafiche.Size = new System.Drawing.Size(167, 54);
            this.btnAnagrafiche.TabIndex = 0;
            this.btnAnagrafiche.Text = "Anagrafiche";
            this.btnAnagrafiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnagrafiche.Textcolor = System.Drawing.Color.White;
            this.btnAnagrafiche.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnagrafiche.Click += new System.EventHandler(this.btnAnagrafiche_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.Active = false;
            this.btnImpostazioni.Activecolor = System.Drawing.Color.Transparent;
            this.btnImpostazioni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpostazioni.BackColor = System.Drawing.Color.Transparent;
            this.btnImpostazioni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImpostazioni.BorderRadius = 0;
            this.btnImpostazioni.ButtonText = "Impostazioni";
            this.btnImpostazioni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpostazioni.DisabledColor = System.Drawing.Color.Gray;
            this.btnImpostazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioni.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImpostazioni.Iconimage = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngImpostazioni;
            this.btnImpostazioni.Iconimage_right = null;
            this.btnImpostazioni.Iconimage_right_Selected = null;
            this.btnImpostazioni.Iconimage_Selected = null;
            this.btnImpostazioni.IconMarginLeft = 0;
            this.btnImpostazioni.IconMarginRight = 0;
            this.btnImpostazioni.IconRightVisible = true;
            this.btnImpostazioni.IconRightZoom = 0D;
            this.btnImpostazioni.IconVisible = true;
            this.btnImpostazioni.IconZoom = 35D;
            this.btnImpostazioni.IsTab = false;
            this.btnImpostazioni.Location = new System.Drawing.Point(5, 255);
            this.btnImpostazioni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImpostazioni.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnImpostazioni.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImpostazioni.selected = false;
            this.btnImpostazioni.Size = new System.Drawing.Size(167, 54);
            this.btnImpostazioni.TabIndex = 0;
            this.btnImpostazioni.Text = "Impostazioni";
            this.btnImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImpostazioni.Textcolor = System.Drawing.Color.White;
            this.btnImpostazioni.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnEventi
            // 
            this.btnEventi.Active = false;
            this.btnEventi.Activecolor = System.Drawing.Color.Transparent;
            this.btnEventi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEventi.BackColor = System.Drawing.Color.Transparent;
            this.btnEventi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEventi.BorderRadius = 0;
            this.btnEventi.ButtonText = "Eventi";
            this.btnEventi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventi.DisabledColor = System.Drawing.Color.Gray;
            this.btnEventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEventi.Iconimage = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngEventi;
            this.btnEventi.Iconimage_right = null;
            this.btnEventi.Iconimage_right_Selected = null;
            this.btnEventi.Iconimage_Selected = null;
            this.btnEventi.IconMarginLeft = 0;
            this.btnEventi.IconMarginRight = 0;
            this.btnEventi.IconRightVisible = true;
            this.btnEventi.IconRightZoom = 0D;
            this.btnEventi.IconVisible = true;
            this.btnEventi.IconZoom = 35D;
            this.btnEventi.IsTab = false;
            this.btnEventi.Location = new System.Drawing.Point(5, 148);
            this.btnEventi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventi.Name = "btnEventi";
            this.btnEventi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEventi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEventi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEventi.selected = false;
            this.btnEventi.Size = new System.Drawing.Size(167, 54);
            this.btnEventi.TabIndex = 0;
            this.btnEventi.Text = "Eventi";
            this.btnEventi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEventi.Textcolor = System.Drawing.Color.White;
            this.btnEventi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventi.Click += new System.EventHandler(this.btnEventi_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Active = false;
            this.btnDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = global::Gestione_Iscrizioni_e_Anagrafica.Properties.Resources.pngHome;
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 35D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(5, 94);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(167, 54);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelDragControl.ResumeLayout(false);
            this.panelDragControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceIconsClone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduceIcons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnEsci;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnagrafiche;
        private Bunifu.Framework.UI.BunifuFlatButton btnImpostazioni;
        private Bunifu.Framework.UI.BunifuFlatButton btnEventi;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnReduceIcons;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuImageButton btnReduceIconsClone;
        private System.Windows.Forms.Panel panelLayout;
        private Bunifu.Framework.UI.BunifuImageButton btnAbout;
    }
}