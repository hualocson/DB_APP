namespace App_Project_Management.Views
{
    partial class frmAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProject));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlWindowTools = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHide = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMax = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnQuit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.roundedAddProjectForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragAddProjectForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbProjectName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dpDeadline = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKey = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlWindowTools.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlWindowTools
            //
            this.pnlWindowTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            this.pnlWindowTools.Controls.Add(this.label2);
            this.pnlWindowTools.Controls.Add(this.btnHide);
            this.pnlWindowTools.Controls.Add(this.btnMax);
            this.pnlWindowTools.Controls.Add(this.btnQuit);
            this.pnlWindowTools.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlWindowTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowTools.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowTools.Name = "pnlWindowTools";
            this.pnlWindowTools.Size = new System.Drawing.Size(434, 30);
            this.pnlWindowTools.TabIndex = 2;
            //
            // label2
            //
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnHide.Enabled = false;
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
            this.btnHide.Location = new System.Drawing.Point(344, 0);
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
            this.btnMax.Enabled = false;
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
            this.btnMax.Location = new System.Drawing.Point(374, 0);
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
            this.btnQuit.Location = new System.Drawing.Point(404, 0);
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
            // roundedAddProjectForm
            //
            this.roundedAddProjectForm.ElipseRadius = 10;
            this.roundedAddProjectForm.TargetControl = this;
            //
            // dragAddProjectForm
            //
            this.dragAddProjectForm.Fixed = true;
            this.dragAddProjectForm.Horizontal = true;
            this.dragAddProjectForm.TargetControl = this.pnlWindowTools;
            this.dragAddProjectForm.Vertical = true;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name";
            //
            // txbProjectName
            //
            this.txbProjectName.AcceptsReturn = false;
            this.txbProjectName.AcceptsTab = false;
            this.txbProjectName.AnimationSpeed = 200;
            this.txbProjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbProjectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbProjectName.BackColor = System.Drawing.Color.Transparent;
            this.txbProjectName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbProjectName.BackgroundImage")));
            this.txbProjectName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbProjectName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbProjectName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbProjectName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbProjectName.BorderRadius = 1;
            this.txbProjectName.BorderThickness = 1;
            this.txbProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbProjectName.DefaultText = "";
            this.txbProjectName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txbProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.txbProjectName.HideSelection = true;
            this.txbProjectName.IconLeft = null;
            this.txbProjectName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.IconPadding = 10;
            this.txbProjectName.IconRight = null;
            this.txbProjectName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.Lines = new string[0];
            this.txbProjectName.Location = new System.Drawing.Point(186, 69);
            this.txbProjectName.MaxLength = 32767;
            this.txbProjectName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbProjectName.Modified = false;
            this.txbProjectName.Multiline = false;
            this.txbProjectName.Name = "txbProjectName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbProjectName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnIdleState = stateProperties8;
            this.txbProjectName.Padding = new System.Windows.Forms.Padding(3);
            this.txbProjectName.PasswordChar = '\0';
            this.txbProjectName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbProjectName.PlaceholderText = "Enter text";
            this.txbProjectName.ReadOnly = false;
            this.txbProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbProjectName.SelectedText = "";
            this.txbProjectName.SelectionLength = 0;
            this.txbProjectName.SelectionStart = 0;
            this.txbProjectName.ShortcutsEnabled = true;
            this.txbProjectName.Size = new System.Drawing.Size(218, 41);
            this.txbProjectName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbProjectName.TabIndex = 4;
            this.txbProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbProjectName.TextMarginBottom = 0;
            this.txbProjectName.TextMarginLeft = 3;
            this.txbProjectName.TextMarginTop = 0;
            this.txbProjectName.TextPlaceholder = "Enter text";
            this.txbProjectName.UseSystemPasswordChar = false;
            this.txbProjectName.WordWrap = true;
            //
            // dpDeadline
            //
            this.dpDeadline.BackColor = System.Drawing.Color.Transparent;
            this.dpDeadline.BorderRadius = 1;
            this.dpDeadline.Color = System.Drawing.Color.Silver;
            this.dpDeadline.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpDeadline.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpDeadline.DisabledColor = System.Drawing.Color.Gray;
            this.dpDeadline.DisplayWeekNumbers = false;
            this.dpDeadline.DPHeight = 0;
            this.dpDeadline.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpDeadline.FillDatePicker = false;
            this.dpDeadline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dpDeadline.Icon = ((System.Drawing.Image)(resources.GetObject("dpDeadline.Icon")));
            this.dpDeadline.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dpDeadline.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpDeadline.LeftTextMargin = 5;
            this.dpDeadline.Location = new System.Drawing.Point(186, 140);
            this.dpDeadline.MinimumSize = new System.Drawing.Size(0, 32);
            this.dpDeadline.Name = "dpDeadline";
            this.dpDeadline.Size = new System.Drawing.Size(218, 32);
            this.dpDeadline.TabIndex = 5;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deadline";
            //
            // txbKey
            //
            this.txbKey.AcceptsReturn = false;
            this.txbKey.AcceptsTab = false;
            this.txbKey.AnimationSpeed = 200;
            this.txbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbKey.BackColor = System.Drawing.Color.Transparent;
            this.txbKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbKey.BackgroundImage")));
            this.txbKey.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txbKey.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbKey.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txbKey.BorderColorIdle = System.Drawing.Color.Silver;
            this.txbKey.BorderRadius = 1;
            this.txbKey.BorderThickness = 1;
            this.txbKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbKey.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txbKey.DefaultText = "";
            this.txbKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txbKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.txbKey.HideSelection = true;
            this.txbKey.IconLeft = null;
            this.txbKey.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbKey.IconPadding = 10;
            this.txbKey.IconRight = null;
            this.txbKey.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbKey.Lines = new string[0];
            this.txbKey.Location = new System.Drawing.Point(186, 208);
            this.txbKey.MaxLength = 32767;
            this.txbKey.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbKey.Modified = false;
            this.txbKey.Multiline = false;
            this.txbKey.Name = "txbKey";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbKey.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbKey.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbKey.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbKey.OnIdleState = stateProperties4;
            this.txbKey.Padding = new System.Windows.Forms.Padding(3);
            this.txbKey.PasswordChar = '\0';
            this.txbKey.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbKey.PlaceholderText = "Enter text";
            this.txbKey.ReadOnly = false;
            this.txbKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbKey.SelectedText = "";
            this.txbKey.SelectionLength = 0;
            this.txbKey.SelectionStart = 0;
            this.txbKey.ShortcutsEnabled = true;
            this.txbKey.Size = new System.Drawing.Size(218, 41);
            this.txbKey.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbKey.TabIndex = 8;
            this.txbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbKey.TextMarginBottom = 0;
            this.txbKey.TextMarginLeft = 3;
            this.txbKey.TextMarginTop = 0;
            this.txbKey.TextPlaceholder = "Enter text";
            this.txbKey.UseSystemPasswordChar = false;
            this.txbKey.WordWrap = true;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company";
            //
            // cmbCompany
            //
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(186, 282);
            this.cmbCompany.Name = "txbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(217, 31);
            this.cmbCompany.TabIndex = 9;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(186, 282);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(217, 26);
            this.cmbCompany.TabIndex = 9;
            this.cmbCompany.Text = "Select Company";
            //
            // pnlButton
            //
            this.pnlButton.Controls.Add(this.btnAdd);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 338);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.pnlButton.Size = new System.Drawing.Size(434, 40);
            this.pnlButton.TabIndex = 10;
            //
            // btnAdd
            //
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAdd.IdleBorderRadius = 10;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(322, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 10;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnAdd.onHoverState.BorderRadius = 10;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAdd.OnIdleState.BorderRadius = 10;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnAdd.OnPressedState.BorderRadius = 10;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(102, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // frmAddProject
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(434, 378);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpDeadline);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWindowTools);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddProject";
            this.Load += new System.EventHandler(this.frmAddProject_Load);
            this.pnlWindowTools.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindowTools;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuImageButton btnHide;
        private Bunifu.UI.WinForms.BunifuImageButton btnMax;
        private Bunifu.UI.WinForms.BunifuImageButton btnQuit;
        private Bunifu.Framework.UI.BunifuElipse roundedAddProjectForm;
        private Bunifu.Framework.UI.BunifuDragControl dragAddProjectForm;
        private Bunifu.UI.WinForms.BunifuTextBox txbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDeadline;
        private Bunifu.UI.WinForms.BunifuTextBox txbProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
    }
}