namespace WebBrowser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtSearchUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAccount = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnFav = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnHome = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.imgSpinner = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imgRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCards1.Controls.Add(this.txtSearchUrl);
            this.bunifuCards1.Controls.Add(this.btnAccount);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.btnFav);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnBack);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1042, 77);
            this.bunifuCards1.TabIndex = 0;
            // 
            // txtSearchUrl
            // 
            this.txtSearchUrl.AcceptsReturn = false;
            this.txtSearchUrl.AcceptsTab = false;
            this.txtSearchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchUrl.AnimationSpeed = 200;
            this.txtSearchUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchUrl.BackgroundImage")));
            this.txtSearchUrl.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(108)))), ((int)(((byte)(201)))));
            this.txtSearchUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(138)))), ((int)(((byte)(207)))));
            this.txtSearchUrl.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearchUrl.BorderRadius = 30;
            this.txtSearchUrl.BorderThickness = 1;
            this.txtSearchUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUrl.DefaultFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchUrl.DefaultText = "";
            this.txtSearchUrl.FillColor = System.Drawing.Color.White;
            this.txtSearchUrl.HideSelection = true;
            this.txtSearchUrl.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchUrl.IconLeft")));
            this.txtSearchUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUrl.IconPadding = 10;
            this.txtSearchUrl.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchUrl.IconRight")));
            this.txtSearchUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUrl.Lines = new string[0];
            this.txtSearchUrl.Location = new System.Drawing.Point(258, 14);
            this.txtSearchUrl.MaxLength = 32767;
            this.txtSearchUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchUrl.Modified = false;
            this.txtSearchUrl.Multiline = false;
            this.txtSearchUrl.Name = "txtSearchUrl";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(108)))), ((int)(((byte)(201)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(138)))), ((int)(((byte)(207)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchUrl.OnIdleState = stateProperties4;
            this.txtSearchUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearchUrl.PasswordChar = '\0';
            this.txtSearchUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchUrl.PlaceholderText = "Enter URL";
            this.txtSearchUrl.ReadOnly = false;
            this.txtSearchUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchUrl.SelectedText = "";
            this.txtSearchUrl.SelectionLength = 0;
            this.txtSearchUrl.SelectionStart = 0;
            this.txtSearchUrl.ShortcutsEnabled = true;
            this.txtSearchUrl.Size = new System.Drawing.Size(631, 51);
            this.txtSearchUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchUrl.TabIndex = 5;
            this.txtSearchUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchUrl.TextMarginBottom = 0;
            this.txtSearchUrl.TextMarginLeft = 3;
            this.txtSearchUrl.TextMarginTop = 0;
            this.txtSearchUrl.TextPlaceholder = "Enter URL";
            this.txtSearchUrl.UseSystemPasswordChar = false;
            this.txtSearchUrl.WordWrap = true;
            this.txtSearchUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchUrl_KeyUp);
            // 
            // btnAccount
            // 
            this.btnAccount.ActiveImage = null;
            this.btnAccount.AllowAnimations = true;
            this.btnAccount.AllowBuffering = false;
            this.btnAccount.AllowToggling = false;
            this.btnAccount.AllowZooming = true;
            this.btnAccount.AllowZoomingOnFocus = false;
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.ErrorImage")));
            this.btnAccount.FadeWhenInactive = false;
            this.btnAccount.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageActive = null;
            this.btnAccount.ImageLocation = null;
            this.btnAccount.ImageMargin = 10;
            this.btnAccount.ImageSize = new System.Drawing.Size(51, 46);
            this.btnAccount.ImageZoomSize = new System.Drawing.Size(61, 56);
            this.btnAccount.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.InitialImage")));
            this.btnAccount.Location = new System.Drawing.Point(968, 15);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Rotation = 0;
            this.btnAccount.ShowActiveImage = true;
            this.btnAccount.ShowCursorChanges = true;
            this.btnAccount.ShowImageBorders = true;
            this.btnAccount.ShowSizeMarkers = false;
            this.btnAccount.Size = new System.Drawing.Size(61, 56);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.ToolTipText = "Account";
            this.btnAccount.WaitOnLoad = false;
            this.btnAccount.Zoom = 10;
            this.btnAccount.ZoomSpeed = 10;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
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
            this.btnRefresh.ImageMargin = 10;
            this.btnRefresh.ImageSize = new System.Drawing.Size(34, 41);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(44, 51);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(208, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(44, 51);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFav
            // 
            this.btnFav.ActiveImage = null;
            this.btnFav.AllowAnimations = true;
            this.btnFav.AllowBuffering = false;
            this.btnFav.AllowToggling = false;
            this.btnFav.AllowZooming = true;
            this.btnFav.AllowZoomingOnFocus = false;
            this.btnFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFav.BackColor = System.Drawing.Color.Transparent;
            this.btnFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFav.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFav.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFav.ErrorImage")));
            this.btnFav.FadeWhenInactive = false;
            this.btnFav.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFav.Image = ((System.Drawing.Image)(resources.GetObject("btnFav.Image")));
            this.btnFav.ImageActive = null;
            this.btnFav.ImageLocation = null;
            this.btnFav.ImageMargin = 10;
            this.btnFav.ImageSize = new System.Drawing.Size(39, 40);
            this.btnFav.ImageZoomSize = new System.Drawing.Size(49, 50);
            this.btnFav.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFav.InitialImage")));
            this.btnFav.Location = new System.Drawing.Point(906, 18);
            this.btnFav.Name = "btnFav";
            this.btnFav.Rotation = 0;
            this.btnFav.ShowActiveImage = true;
            this.btnFav.ShowCursorChanges = true;
            this.btnFav.ShowImageBorders = true;
            this.btnFav.ShowSizeMarkers = false;
            this.btnFav.Size = new System.Drawing.Size(49, 50);
            this.btnFav.TabIndex = 3;
            this.btnFav.ToolTipText = "Favourite";
            this.btnFav.WaitOnLoad = false;
            this.btnFav.Zoom = 10;
            this.btnFav.ZoomSpeed = 10;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
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
            this.btnForward.ImageMargin = 10;
            this.btnForward.ImageSize = new System.Drawing.Size(60, 55);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(70, 65);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(66, 9);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(70, 65);
            this.btnForward.TabIndex = 2;
            this.btnForward.ToolTipText = "Forward";
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 10;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnHome
            // 
            this.btnHome.ActiveImage = null;
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowBuffering = false;
            this.btnHome.AllowToggling = false;
            this.btnHome.AllowZooming = true;
            this.btnHome.AllowZoomingOnFocus = false;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ErrorImage")));
            this.btnHome.FadeWhenInactive = false;
            this.btnHome.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.ImageLocation = null;
            this.btnHome.ImageMargin = 10;
            this.btnHome.ImageSize = new System.Drawing.Size(69, 55);
            this.btnHome.ImageZoomSize = new System.Drawing.Size(79, 65);
            this.btnHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHome.InitialImage")));
            this.btnHome.Location = new System.Drawing.Point(132, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 0;
            this.btnHome.ShowActiveImage = true;
            this.btnHome.ShowCursorChanges = true;
            this.btnHome.ShowImageBorders = true;
            this.btnHome.ShowSizeMarkers = false;
            this.btnHome.Size = new System.Drawing.Size(79, 65);
            this.btnHome.TabIndex = 3;
            this.btnHome.ToolTipText = "Home";
            this.btnHome.WaitOnLoad = false;
            this.btnHome.Zoom = 10;
            this.btnHome.ZoomSpeed = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 10;
            this.btnBack.ImageSize = new System.Drawing.Size(60, 55);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(70, 65);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(0, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(70, 65);
            this.btnBack.TabIndex = 1;
            this.btnBack.ToolTipText = "Back";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 10;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1039, 536);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // imgSpinner
            // 
            this.imgSpinner.ActiveImage = null;
            this.imgSpinner.AllowAnimations = true;
            this.imgSpinner.AllowBuffering = false;
            this.imgSpinner.AllowToggling = false;
            this.imgSpinner.AllowZooming = true;
            this.imgSpinner.AllowZoomingOnFocus = false;
            this.imgSpinner.BackColor = System.Drawing.Color.Transparent;
            this.imgSpinner.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgSpinner.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgSpinner.ErrorImage")));
            this.imgSpinner.FadeWhenInactive = false;
            this.imgSpinner.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));
            this.imgSpinner.ImageActive = null;
            this.imgSpinner.ImageLocation = null;
            this.imgSpinner.ImageMargin = 10;
            this.imgSpinner.ImageSize = new System.Drawing.Size(34, 41);
            this.imgSpinner.ImageZoomSize = new System.Drawing.Size(44, 51);
            this.imgSpinner.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgSpinner.InitialImage")));
            this.imgSpinner.Location = new System.Drawing.Point(105, 514);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Rotation = 0;
            this.imgSpinner.ShowActiveImage = true;
            this.imgSpinner.ShowCursorChanges = true;
            this.imgSpinner.ShowImageBorders = true;
            this.imgSpinner.ShowSizeMarkers = false;
            this.imgSpinner.Size = new System.Drawing.Size(44, 51);
            this.imgSpinner.TabIndex = 5;
            this.imgSpinner.ToolTipText = "Refresh";
            this.imgSpinner.Visible = false;
            this.imgSpinner.WaitOnLoad = false;
            this.imgSpinner.Zoom = 10;
            this.imgSpinner.ZoomSpeed = 10;
            // 
            // imgRefresh
            // 
            this.imgRefresh.ActiveImage = null;
            this.imgRefresh.AllowAnimations = true;
            this.imgRefresh.AllowBuffering = false;
            this.imgRefresh.AllowToggling = false;
            this.imgRefresh.AllowZooming = true;
            this.imgRefresh.AllowZoomingOnFocus = false;
            this.imgRefresh.BackColor = System.Drawing.Color.Transparent;
            this.imgRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgRefresh.ErrorImage")));
            this.imgRefresh.FadeWhenInactive = false;
            this.imgRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.ImageActive = null;
            this.imgRefresh.ImageLocation = null;
            this.imgRefresh.ImageMargin = 10;
            this.imgRefresh.ImageSize = new System.Drawing.Size(34, 41);
            this.imgRefresh.ImageZoomSize = new System.Drawing.Size(44, 51);
            this.imgRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgRefresh.InitialImage")));
            this.imgRefresh.Location = new System.Drawing.Point(44, 514);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Rotation = 0;
            this.imgRefresh.ShowActiveImage = true;
            this.imgRefresh.ShowCursorChanges = true;
            this.imgRefresh.ShowImageBorders = true;
            this.imgRefresh.ShowSizeMarkers = false;
            this.imgRefresh.Size = new System.Drawing.Size(44, 51);
            this.imgRefresh.TabIndex = 6;
            this.imgRefresh.ToolTipText = "Refresh";
            this.imgRefresh.Visible = false;
            this.imgRefresh.WaitOnLoad = false;
            this.imgRefresh.Zoom = 10;
            this.imgRefresh.ZoomSpeed = 10;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1041, 607);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnAccount;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnFav;
        private Bunifu.UI.WinForms.BunifuImageButton btnHome;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Bunifu.UI.WinForms.BunifuImageButton imgSpinner;
        private Bunifu.UI.WinForms.BunifuImageButton imgRefresh;
    }
}