namespace WebBrowser
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.lstFav = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges1;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(175)))));
            this.btnLogout.IdleBorderRadius = 15;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btnLogout.IdleIconLeftImage = null;
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(315, 320);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 15;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(175)))));
            this.btnLogout.onHoverState.BorderRadius = 15;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(175)))));
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(175)))));
            this.btnLogout.OnIdleState.BorderRadius = 15;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.IconLeftImage = null;
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btnLogout.OnPressedState.BorderRadius = 15;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(150, 39);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AllowParentOverrides = false;
            this.lblUsername.AutoEllipsis = false;
            this.lblUsername.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location = new System.Drawing.Point(342, 115);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "bunifuLabel1";
            this.lblUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lstFav
            // 
            this.lstFav.FormattingEnabled = true;
            this.lstFav.ItemHeight = 16;
            this.lstFav.Location = new System.Drawing.Point(331, 193);
            this.lstFav.Name = "lstFav";
            this.lstFav.Size = new System.Drawing.Size(120, 84);
            this.lstFav.TabIndex = 7;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFav);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuLabel lblUsername;
        private System.Windows.Forms.ListBox lstFav;
    }
}