namespace WebBrowser
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.iconLoader = new System.Windows.Forms.PictureBox();
            this.btnAccount = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.iconLock = new System.Windows.Forms.PictureBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLoader)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 73);
            this.panel1.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlBody.Controls.Add(this.iconLoader);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 73);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(937, 601);
            this.pnlBody.TabIndex = 2;
            // 
            // iconLoader
            // 
            this.iconLoader.Image = global::WebBrowser.Properties.Resources.output_onlinepngtools__6_;
            this.iconLoader.Location = new System.Drawing.Point(160, 66);
            this.iconLoader.Name = "iconLoader";
            this.iconLoader.Size = new System.Drawing.Size(36, 35);
            this.iconLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconLoader.TabIndex = 0;
            this.iconLoader.TabStop = false;
            // 
            // btnAccount
            // 
            this.btnAccount.ActiveImage = null;
            this.btnAccount.AllowAnimations = true;
            this.btnAccount.AllowBuffering = false;
            this.btnAccount.AllowToggling = false;
            this.btnAccount.AllowZooming = true;
            this.btnAccount.AllowZoomingOnFocus = false;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.ErrorImage")));
            this.btnAccount.FadeWhenInactive = false;
            this.btnAccount.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageActive = null;
            this.btnAccount.ImageLocation = null;
            this.btnAccount.ImageMargin = 40;
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btnAccount.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.InitialImage")));
            this.btnAccount.Location = new System.Drawing.Point(877, 7);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Rotation = 0;
            this.btnAccount.ShowActiveImage = true;
            this.btnAccount.ShowCursorChanges = true;
            this.btnAccount.ShowImageBorders = true;
            this.btnAccount.ShowSizeMarkers = false;
            this.btnAccount.Size = new System.Drawing.Size(60, 60);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.ToolTipText = "";
            this.btnAccount.WaitOnLoad = false;
            this.btnAccount.Zoom = 40;
            this.btnAccount.ZoomSpeed = 10;
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 40;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(0, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 1;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 40;
            this.btnBack.ZoomSpeed = 10;
            // 
            // btnForward
            // 
            this.btnForward.ActiveImage = null;
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBuffering = false;
            this.btnForward.AllowToggling = false;
            this.btnForward.AllowZooming = true;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = false;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 40;
            this.btnForward.ImageSize = new System.Drawing.Size(20, 20);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(48, 7);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(60, 60);
            this.btnForward.TabIndex = 2;
            this.btnForward.ToolTipText = "";
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 40;
            this.btnForward.ZoomSpeed = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = true;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = false;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 40;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(99, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.ToolTipText = "";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 40;
            this.btnRefresh.ZoomSpeed = 10;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.iconLock);
            this.bunifuPanel1.Controls.Add(this.txtURL);
            this.bunifuPanel1.Location = new System.Drawing.Point(160, 13);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(714, 43);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // iconLock
            // 
            this.iconLock.BackColor = System.Drawing.Color.Transparent;
            this.iconLock.Image = global::WebBrowser.Properties.Resources.icone_de_cadenas_de_securite_gris;
            this.iconLock.Location = new System.Drawing.Point(8, 3);
            this.iconLock.Name = "iconLock";
            this.iconLock.Size = new System.Drawing.Size(19, 37);
            this.iconLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconLock.TabIndex = 0;
            this.iconLock.TabStop = false;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtURL.ForeColor = System.Drawing.Color.Black;
            this.txtURL.Location = new System.Drawing.Point(33, 11);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(640, 23);
            this.txtURL.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(937, 674);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLoader)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBody;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox iconLock;
        private System.Windows.Forms.TextBox txtURL;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnAccount;
        private System.Windows.Forms.PictureBox iconLoader;
    }
}

