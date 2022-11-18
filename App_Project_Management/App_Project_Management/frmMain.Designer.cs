namespace App_Project_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.pnlWindowTools = new System.Windows.Forms.Panel();
            this.btnHide = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMax = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnQuit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.roundedFormMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMembers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProjects = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCompanies = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main = new Bunifu.UI.WinForms.BunifuPages();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.companyTabPage = new App_Project_Management.Views.CompanyPage();
            this.projectTab = new System.Windows.Forms.TabPage();
            this.projectPage = new App_Project_Management.Views.ProjectPage();
            this.memberTab = new System.Windows.Forms.TabPage();
            this.memberPage = new App_Project_Management.Views.MemberPage();
            this.taskPage = new System.Windows.Forms.TabPage();
            this.taskPage2 = new App_Project_Management.Views.TaskPage();
            this.taskPage1 = new App_Project_Management.Views.TaskPage();
            this.dragFormMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlWindowTools.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.projectTab.SuspendLayout();
            this.memberTab.SuspendLayout();
            this.taskPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindowTools
            // 
            this.pnlWindowTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlWindowTools.Controls.Add(this.btnHide);
            this.pnlWindowTools.Controls.Add(this.btnMax);
            this.pnlWindowTools.Controls.Add(this.btnQuit);
            this.pnlWindowTools.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlWindowTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowTools.Location = new System.Drawing.Point(300, 0);
            this.pnlWindowTools.Name = "pnlWindowTools";
            this.pnlWindowTools.Size = new System.Drawing.Size(1066, 30);
            this.pnlWindowTools.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.ActiveImage = null;
            this.btnHide.AllowAnimations = true;
            this.btnHide.AllowBuffering = false;
            this.btnHide.AllowToggling = false;
            this.btnHide.AllowZooming = true;
            this.btnHide.AllowZoomingOnFocus = false;
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHide.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHide.ErrorImage")));
            this.btnHide.FadeWhenInactive = false;
            this.btnHide.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.ImageActive = null;
            this.btnHide.ImageLocation = null;
            this.btnHide.ImageMargin = 0;
            this.btnHide.ImageSize = new System.Drawing.Size(29, 29);
            this.btnHide.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnHide.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHide.InitialImage")));
            this.btnHide.Location = new System.Drawing.Point(976, 0);
            this.btnHide.Margin = new System.Windows.Forms.Padding(0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Rotation = 0;
            this.btnHide.ShowActiveImage = true;
            this.btnHide.ShowCursorChanges = true;
            this.btnHide.ShowImageBorders = false;
            this.btnHide.ShowSizeMarkers = false;
            this.btnHide.Size = new System.Drawing.Size(30, 30);
            this.btnHide.TabIndex = 3;
            this.btnHide.ToolTipText = "";
            this.btnHide.WaitOnLoad = false;
            this.btnHide.Zoom = 0;
            this.btnHide.ZoomSpeed = 10;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnMax
            // 
            this.btnMax.ActiveImage = null;
            this.btnMax.AllowAnimations = true;
            this.btnMax.AllowBuffering = false;
            this.btnMax.AllowToggling = false;
            this.btnMax.AllowZooming = true;
            this.btnMax.AllowZoomingOnFocus = false;
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMax.ErrorImage")));
            this.btnMax.FadeWhenInactive = false;
            this.btnMax.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.ImageLocation = null;
            this.btnMax.ImageMargin = 0;
            this.btnMax.ImageSize = new System.Drawing.Size(29, 29);
            this.btnMax.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnMax.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMax.InitialImage")));
            this.btnMax.Location = new System.Drawing.Point(1006, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rotation = 0;
            this.btnMax.ShowActiveImage = true;
            this.btnMax.ShowCursorChanges = true;
            this.btnMax.ShowImageBorders = false;
            this.btnMax.ShowSizeMarkers = false;
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 2;
            this.btnMax.ToolTipText = "";
            this.btnMax.WaitOnLoad = false;
            this.btnMax.Zoom = 0;
            this.btnMax.ZoomSpeed = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.ActiveImage = null;
            this.btnQuit.AllowAnimations = true;
            this.btnQuit.AllowBuffering = false;
            this.btnQuit.AllowToggling = false;
            this.btnQuit.AllowZooming = true;
            this.btnQuit.AllowZoomingOnFocus = false;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.ErrorImage")));
            this.btnQuit.FadeWhenInactive = false;
            this.btnQuit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageActive = null;
            this.btnQuit.ImageLocation = null;
            this.btnQuit.ImageMargin = 0;
            this.btnQuit.ImageSize = new System.Drawing.Size(29, 29);
            this.btnQuit.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnQuit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.InitialImage")));
            this.btnQuit.Location = new System.Drawing.Point(1036, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Rotation = 0;
            this.btnQuit.ShowActiveImage = true;
            this.btnQuit.ShowCursorChanges = true;
            this.btnQuit.ShowImageBorders = false;
            this.btnQuit.ShowSizeMarkers = false;
            this.btnQuit.Size = new System.Drawing.Size(30, 30);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.ToolTipText = "";
            this.btnQuit.WaitOnLoad = false;
            this.btnQuit.Zoom = 0;
            this.btnQuit.ZoomSpeed = 10;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // roundedFormMain
            // 
            this.roundedFormMain.ElipseRadius = 30;
            this.roundedFormMain.TargetControl = this;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 768);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnMembers);
            this.pnlMenu.Controls.Add(this.btnProjects);
            this.pnlMenu.Controls.Add(this.btnCompanies);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMenu.Size = new System.Drawing.Size(300, 668);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 150;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "Log Out";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges1;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 0;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.IdleBorderRadius = 20;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.IdleIconLeftImage")));
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(20, 584);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 20;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.onHoverState.BorderRadius = 20;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.OnIdleState.BorderRadius = 20;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLogout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnIdleState.IconLeftImage")));
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.OnPressedState.BorderRadius = 20;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(260, 64);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.AllowAnimations = true;
            this.btnMembers.AllowMouseEffects = true;
            this.btnMembers.AllowToggling = false;
            this.btnMembers.AnimationSpeed = 150;
            this.btnMembers.AutoGenerateColors = false;
            this.btnMembers.AutoRoundBorders = false;
            this.btnMembers.AutoSizeLeftIcon = true;
            this.btnMembers.AutoSizeRightIcon = true;
            this.btnMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnMembers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMembers.BackgroundImage")));
            this.btnMembers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMembers.ButtonText = "Members";
            this.btnMembers.ButtonTextMarginLeft = 0;
            this.btnMembers.ColorContrastOnClick = 45;
            this.btnMembers.ColorContrastOnHover = 45;
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnMembers.CustomizableEdges = borderEdges2;
            this.btnMembers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMembers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMembers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMembers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMembers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnMembers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMembers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnMembers.IconMarginLeft = 11;
            this.btnMembers.IconPadding = 0;
            this.btnMembers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembers.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnMembers.IconSize = 25;
            this.btnMembers.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.IdleBorderRadius = 20;
            this.btnMembers.IdleBorderThickness = 1;
            this.btnMembers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnMembers.IdleIconLeftImage")));
            this.btnMembers.IdleIconRightImage = null;
            this.btnMembers.IndicateFocus = false;
            this.btnMembers.Location = new System.Drawing.Point(20, 158);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMembers.OnDisabledState.BorderRadius = 20;
            this.btnMembers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMembers.OnDisabledState.BorderThickness = 1;
            this.btnMembers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMembers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMembers.OnDisabledState.IconLeftImage = null;
            this.btnMembers.OnDisabledState.IconRightImage = null;
            this.btnMembers.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.onHoverState.BorderRadius = 20;
            this.btnMembers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMembers.onHoverState.BorderThickness = 1;
            this.btnMembers.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnMembers.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.onHoverState.IconLeftImage = null;
            this.btnMembers.onHoverState.IconRightImage = null;
            this.btnMembers.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.OnIdleState.BorderRadius = 20;
            this.btnMembers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMembers.OnIdleState.BorderThickness = 1;
            this.btnMembers.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMembers.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnMembers.OnIdleState.IconLeftImage")));
            this.btnMembers.OnIdleState.IconRightImage = null;
            this.btnMembers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.OnPressedState.BorderRadius = 20;
            this.btnMembers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMembers.OnPressedState.BorderThickness = 1;
            this.btnMembers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnMembers.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnMembers.OnPressedState.IconLeftImage = null;
            this.btnMembers.OnPressedState.IconRightImage = null;
            this.btnMembers.Size = new System.Drawing.Size(260, 64);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMembers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMembers.TextMarginLeft = 0;
            this.btnMembers.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMembers.UseDefaultRadiusAndThickness = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.AllowAnimations = true;
            this.btnProjects.AllowMouseEffects = true;
            this.btnProjects.AllowToggling = false;
            this.btnProjects.AnimationSpeed = 150;
            this.btnProjects.AutoGenerateColors = false;
            this.btnProjects.AutoRoundBorders = false;
            this.btnProjects.AutoSizeLeftIcon = true;
            this.btnProjects.AutoSizeRightIcon = true;
            this.btnProjects.BackColor = System.Drawing.Color.Transparent;
            this.btnProjects.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjects.BackgroundImage")));
            this.btnProjects.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProjects.ButtonText = "Projects";
            this.btnProjects.ButtonTextMarginLeft = 0;
            this.btnProjects.ColorContrastOnClick = 45;
            this.btnProjects.ColorContrastOnHover = 45;
            this.btnProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnProjects.CustomizableEdges = borderEdges3;
            this.btnProjects.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProjects.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProjects.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProjects.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProjects.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnProjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnProjects.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjects.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnProjects.IconMarginLeft = 11;
            this.btnProjects.IconPadding = 0;
            this.btnProjects.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjects.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjects.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnProjects.IconSize = 25;
            this.btnProjects.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.IdleBorderRadius = 20;
            this.btnProjects.IdleBorderThickness = 1;
            this.btnProjects.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProjects.IdleIconLeftImage")));
            this.btnProjects.IdleIconRightImage = null;
            this.btnProjects.IndicateFocus = false;
            this.btnProjects.Location = new System.Drawing.Point(20, 89);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProjects.OnDisabledState.BorderRadius = 20;
            this.btnProjects.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProjects.OnDisabledState.BorderThickness = 1;
            this.btnProjects.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProjects.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProjects.OnDisabledState.IconLeftImage = null;
            this.btnProjects.OnDisabledState.IconRightImage = null;
            this.btnProjects.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.onHoverState.BorderRadius = 20;
            this.btnProjects.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProjects.onHoverState.BorderThickness = 1;
            this.btnProjects.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnProjects.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.onHoverState.IconLeftImage = null;
            this.btnProjects.onHoverState.IconRightImage = null;
            this.btnProjects.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.OnIdleState.BorderRadius = 20;
            this.btnProjects.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProjects.OnIdleState.BorderThickness = 1;
            this.btnProjects.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnProjects.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnProjects.OnIdleState.IconLeftImage")));
            this.btnProjects.OnIdleState.IconRightImage = null;
            this.btnProjects.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.OnPressedState.BorderRadius = 20;
            this.btnProjects.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProjects.OnPressedState.BorderThickness = 1;
            this.btnProjects.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnProjects.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnProjects.OnPressedState.IconLeftImage = null;
            this.btnProjects.OnPressedState.IconRightImage = null;
            this.btnProjects.Size = new System.Drawing.Size(260, 64);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProjects.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProjects.TextMarginLeft = 0;
            this.btnProjects.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProjects.UseDefaultRadiusAndThickness = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnCompanies
            // 
            this.btnCompanies.AllowAnimations = true;
            this.btnCompanies.AllowMouseEffects = true;
            this.btnCompanies.AllowToggling = false;
            this.btnCompanies.AnimationSpeed = 150;
            this.btnCompanies.AutoGenerateColors = false;
            this.btnCompanies.AutoRoundBorders = false;
            this.btnCompanies.AutoSizeLeftIcon = true;
            this.btnCompanies.AutoSizeRightIcon = true;
            this.btnCompanies.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCompanies.BackColor = System.Drawing.Color.Transparent;
            this.btnCompanies.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompanies.BackgroundImage")));
            this.btnCompanies.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompanies.ButtonText = "Companies";
            this.btnCompanies.ButtonTextMarginLeft = 0;
            this.btnCompanies.ColorContrastOnClick = 45;
            this.btnCompanies.ColorContrastOnHover = 45;
            this.btnCompanies.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnCompanies.CustomizableEdges = borderEdges4;
            this.btnCompanies.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompanies.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCompanies.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCompanies.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCompanies.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnCompanies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCompanies.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompanies.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanies.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnCompanies.IconMarginLeft = 11;
            this.btnCompanies.IconPadding = 0;
            this.btnCompanies.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompanies.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanies.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnCompanies.IconSize = 25;
            this.btnCompanies.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.IdleBorderRadius = 20;
            this.btnCompanies.IdleBorderThickness = 1;
            this.btnCompanies.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCompanies.IdleIconLeftImage")));
            this.btnCompanies.IdleIconRightImage = null;
            this.btnCompanies.IndicateFocus = false;
            this.btnCompanies.Location = new System.Drawing.Point(20, 20);
            this.btnCompanies.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCompanies.OnDisabledState.BorderRadius = 20;
            this.btnCompanies.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompanies.OnDisabledState.BorderThickness = 1;
            this.btnCompanies.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCompanies.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCompanies.OnDisabledState.IconLeftImage = null;
            this.btnCompanies.OnDisabledState.IconRightImage = null;
            this.btnCompanies.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.onHoverState.BorderRadius = 20;
            this.btnCompanies.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompanies.onHoverState.BorderThickness = 1;
            this.btnCompanies.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnCompanies.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.onHoverState.IconLeftImage = null;
            this.btnCompanies.onHoverState.IconRightImage = null;
            this.btnCompanies.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.OnIdleState.BorderRadius = 20;
            this.btnCompanies.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompanies.OnIdleState.BorderThickness = 1;
            this.btnCompanies.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCompanies.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCompanies.OnIdleState.IconLeftImage")));
            this.btnCompanies.OnIdleState.IconRightImage = null;
            this.btnCompanies.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnCompanies.OnPressedState.BorderRadius = 20;
            this.btnCompanies.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompanies.OnPressedState.BorderThickness = 1;
            this.btnCompanies.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnCompanies.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnCompanies.OnPressedState.IconLeftImage = null;
            this.btnCompanies.OnPressedState.IconRightImage = null;
            this.btnCompanies.Size = new System.Drawing.Size(260, 64);
            this.btnCompanies.TabIndex = 0;
            this.btnCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompanies.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCompanies.TextMarginLeft = 0;
            this.btnCompanies.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCompanies.UseDefaultRadiusAndThickness = true;
            this.btnCompanies.Click += new System.EventHandler(this.btnCompanies_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Managment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.main.AllowTransitions = false;
            this.main.Controls.Add(this.companyTab);
            this.main.Controls.Add(this.projectTab);
            this.main.Controls.Add(this.memberTab);
            this.main.Controls.Add(this.taskPage);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main.Location = new System.Drawing.Point(300, 30);
            this.main.Multiline = true;
            this.main.Name = "main";
            this.main.Page = this.memberTab;
            this.main.PageIndex = 2;
            this.main.PageName = "memberTab";
            this.main.PageTitle = "Members";
            this.main.SelectedIndex = 0;
            this.main.Size = new System.Drawing.Size(1066, 738);
            this.main.TabIndex = 2;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 0.6F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 10;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.main.Transition = animation1;
            this.main.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // companyTab
            // 
            this.companyTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.companyTab.Controls.Add(this.companyTabPage);
            this.companyTab.Location = new System.Drawing.Point(4, 4);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyTab.Size = new System.Drawing.Size(1058, 710);
            this.companyTab.TabIndex = 0;
            this.companyTab.Text = "Companies";
            // 
            // companyTabPage
            // 
            this.companyTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.companyTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyTabPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.companyTabPage.Location = new System.Drawing.Point(3, 3);
            this.companyTabPage.Name = "companyTabPage";
            this.companyTabPage.Size = new System.Drawing.Size(1052, 704);
            this.companyTabPage.TabIndex = 0;
            // 
            // projectTab
            // 
            this.projectTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.projectTab.Controls.Add(this.projectPage);
            this.projectTab.Location = new System.Drawing.Point(4, 4);
            this.projectTab.Margin = new System.Windows.Forms.Padding(0);
            this.projectTab.Name = "projectTab";
            this.projectTab.Padding = new System.Windows.Forms.Padding(3);
            this.projectTab.Size = new System.Drawing.Size(192, 74);
            this.projectTab.TabIndex = 1;
            this.projectTab.Text = "Projects";
            // 
            // projectPage
            // 
            this.projectPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.projectPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectPage.Font = new System.Drawing.Font("Arial", 12F);
            this.projectPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.projectPage.Location = new System.Drawing.Point(3, 3);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(186, 68);
            this.projectPage.TabIndex = 0;
            // 
            // memberTab
            // 
            this.memberTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.memberTab.Controls.Add(this.memberPage);
            this.memberTab.Location = new System.Drawing.Point(4, 4);
            this.memberTab.Name = "memberTab";
            this.memberTab.Size = new System.Drawing.Size(1058, 710);
            this.memberTab.TabIndex = 2;
            this.memberTab.Text = "Members";
            // 
            // memberPage
            // 
            this.memberPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.memberPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberPage.Font = new System.Drawing.Font("Arial", 12F);
            this.memberPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.memberPage.Location = new System.Drawing.Point(0, 0);
            this.memberPage.Name = "memberPage";
            this.memberPage.Size = new System.Drawing.Size(1058, 710);
            this.memberPage.TabIndex = 0;
            // 
            // taskPage
            // 
            this.taskPage.Controls.Add(this.taskPage2);
            this.taskPage.Controls.Add(this.taskPage1);
            this.taskPage.Location = new System.Drawing.Point(4, 4);
            this.taskPage.Name = "taskPage";
            this.taskPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskPage.Size = new System.Drawing.Size(192, 56);
            this.taskPage.TabIndex = 3;
            this.taskPage.Text = "Tasks";
            this.taskPage.UseVisualStyleBackColor = true;
            // 
            // taskPage2
            // 
            this.taskPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.taskPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.taskPage2.Location = new System.Drawing.Point(0, 0);
            this.taskPage2.Name = "taskPage2";
            this.taskPage2.Size = new System.Drawing.Size(1058, 710);
            this.taskPage2.TabIndex = 1;
            // 
            // taskPage1
            // 
            this.taskPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.taskPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.taskPage1.Location = new System.Drawing.Point(3, 3);
            this.taskPage1.Name = "taskPage1";
            this.taskPage1.Size = new System.Drawing.Size(186, 50);
            this.taskPage1.TabIndex = 0;
            // 
            // dragFormMain
            // 
            this.dragFormMain.Fixed = true;
            this.dragFormMain.Horizontal = true;
            this.dragFormMain.TargetControl = this.pnlWindowTools;
            this.dragFormMain.Vertical = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.main);
            this.Controls.Add(this.pnlWindowTools);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlWindowTools.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main.ResumeLayout(false);
            this.companyTab.ResumeLayout(false);
            this.projectTab.ResumeLayout(false);
            this.memberTab.ResumeLayout(false);
            this.taskPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindowTools;
        private Bunifu.UI.WinForms.BunifuImageButton btnQuit;
        private Bunifu.UI.WinForms.BunifuImageButton btnHide;
        private Bunifu.UI.WinForms.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuElipse roundedFormMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCompanies;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMembers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProjects;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.TabPage projectTab;
        private Bunifu.Framework.UI.BunifuDragControl dragFormMain;
        private Views.CompanyPage companyTabPage;
        private Views.ProjectPage projectPage;
        private System.Windows.Forms.TabPage memberTab;
        private Views.MemberPage memberPage;
        private System.Windows.Forms.TabPage taskPage;
        public Bunifu.UI.WinForms.BunifuPages main;
        private Views.TaskPage taskPage1;
        private Views.TaskPage taskPage2;
    }
}

