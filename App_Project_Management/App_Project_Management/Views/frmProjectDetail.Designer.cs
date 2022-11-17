namespace App_Project_Management.Views
{
    partial class frmProjectDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDetail));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlWindowTools = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHide = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMax = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnQuit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.dragProjectDetailForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.roundedProjectDetailForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dpCreateAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDeadline = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txbProjectName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnViewTask = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmbTeamList = new System.Windows.Forms.ComboBox();
            this.dtgvTeams = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_lead_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_lead_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignTeam = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlWindowTools.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeams)).BeginInit();
            this.tbpnlButton.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlWindowTools.Size = new System.Drawing.Size(637, 30);
            this.pnlWindowTools.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(188, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project Details";
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
            this.btnHide.Location = new System.Drawing.Point(547, 0);
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
            this.btnMax.Location = new System.Drawing.Point(577, 0);
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
            this.btnQuit.Location = new System.Drawing.Point(607, 0);
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
            // dragProjectDetailForm
            // 
            this.dragProjectDetailForm.Fixed = true;
            this.dragProjectDetailForm.Horizontal = true;
            this.dragProjectDetailForm.TargetControl = this.pnlWindowTools;
            this.dragProjectDetailForm.Vertical = true;
            // 
            // roundedProjectDetailForm
            // 
            this.roundedProjectDetailForm.ElipseRadius = 10;
            this.roundedProjectDetailForm.TargetControl = this;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectName.Location = new System.Drawing.Point(30, 5);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(165, 29);
            this.lbProjectName.TabIndex = 4;
            this.lbProjectName.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create At";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.dpCreateAt);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.dpDeadline);
            this.pnlHeader.Controls.Add(this.txbProjectName);
            this.pnlHeader.Controls.Add(this.lbProjectName);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(637, 95);
            this.pnlHeader.TabIndex = 7;
            // 
            // dpCreateAt
            // 
            this.dpCreateAt.BackColor = System.Drawing.Color.Transparent;
            this.dpCreateAt.BorderRadius = 1;
            this.dpCreateAt.Color = System.Drawing.Color.Silver;
            this.dpCreateAt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpCreateAt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpCreateAt.DisabledColor = System.Drawing.Color.Gray;
            this.dpCreateAt.DisplayWeekNumbers = false;
            this.dpCreateAt.DPHeight = 0;
            this.dpCreateAt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpCreateAt.Enabled = false;
            this.dpCreateAt.FillDatePicker = false;
            this.dpCreateAt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCreateAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.dpCreateAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCreateAt.Icon = ((System.Drawing.Image)(resources.GetObject("dpCreateAt.Icon")));
            this.dpCreateAt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.dpCreateAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpCreateAt.LeftTextMargin = 5;
            this.dpCreateAt.Location = new System.Drawing.Point(308, 36);
            this.dpCreateAt.MinimumSize = new System.Drawing.Size(0, 32);
            this.dpCreateAt.Name = "dpCreateAt";
            this.dpCreateAt.Size = new System.Drawing.Size(133, 32);
            this.dpCreateAt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deadline";
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
            this.dpDeadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.dpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDeadline.Icon = ((System.Drawing.Image)(resources.GetObject("dpDeadline.Icon")));
            this.dpDeadline.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.dpDeadline.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpDeadline.LeftTextMargin = 5;
            this.dpDeadline.Location = new System.Drawing.Point(455, 36);
            this.dpDeadline.MinimumSize = new System.Drawing.Size(0, 32);
            this.dpDeadline.Name = "dpDeadline";
            this.dpDeadline.Size = new System.Drawing.Size(133, 32);
            this.dpDeadline.TabIndex = 7;
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
            this.txbProjectName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.txbProjectName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbProjectName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.txbProjectName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txbProjectName.BorderRadius = 5;
            this.txbProjectName.BorderThickness = 1;
            this.txbProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.DefaultFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjectName.DefaultText = "";
            this.txbProjectName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txbProjectName.HideSelection = true;
            this.txbProjectName.IconLeft = null;
            this.txbProjectName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.IconPadding = 10;
            this.txbProjectName.IconRight = null;
            this.txbProjectName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbProjectName.Lines = new string[0];
            this.txbProjectName.Location = new System.Drawing.Point(53, 36);
            this.txbProjectName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txbProjectName.MaxLength = 32767;
            this.txbProjectName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbProjectName.Modified = false;
            this.txbProjectName.Multiline = false;
            this.txbProjectName.Name = "txbProjectName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbProjectName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbProjectName.OnIdleState = stateProperties4;
            this.txbProjectName.Padding = new System.Windows.Forms.Padding(3);
            this.txbProjectName.PasswordChar = '\0';
            this.txbProjectName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.txbProjectName.PlaceholderText = "";
            this.txbProjectName.ReadOnly = false;
            this.txbProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbProjectName.SelectedText = "";
            this.txbProjectName.SelectionLength = 0;
            this.txbProjectName.SelectionStart = 0;
            this.txbProjectName.ShortcutsEnabled = true;
            this.txbProjectName.Size = new System.Drawing.Size(229, 43);
            this.txbProjectName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbProjectName.TabIndex = 6;
            this.txbProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbProjectName.TextMarginBottom = 0;
            this.txbProjectName.TextMarginLeft = 3;
            this.txbProjectName.TextMarginTop = 0;
            this.txbProjectName.TextPlaceholder = "";
            this.txbProjectName.UseSystemPasswordChar = false;
            this.txbProjectName.WordWrap = true;
            // 
            // btnViewTask
            // 
            this.btnViewTask.AllowAnimations = true;
            this.btnViewTask.AllowMouseEffects = true;
            this.btnViewTask.AllowToggling = false;
            this.btnViewTask.AnimationSpeed = 200;
            this.btnViewTask.AutoGenerateColors = false;
            this.btnViewTask.AutoRoundBorders = false;
            this.btnViewTask.AutoSizeLeftIcon = true;
            this.btnViewTask.AutoSizeRightIcon = true;
            this.btnViewTask.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTask.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnViewTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewTask.BackgroundImage")));
            this.btnViewTask.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewTask.ButtonText = "View Tasks";
            this.btnViewTask.ButtonTextMarginLeft = 0;
            this.btnViewTask.ColorContrastOnClick = 45;
            this.btnViewTask.ColorContrastOnHover = 45;
            this.btnViewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnViewTask.CustomizableEdges = borderEdges4;
            this.btnViewTask.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewTask.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewTask.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewTask.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewTask.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnViewTask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnViewTask.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTask.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewTask.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnViewTask.IconMarginLeft = 11;
            this.btnViewTask.IconPadding = 10;
            this.btnViewTask.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewTask.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewTask.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnViewTask.IconSize = 25;
            this.btnViewTask.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnViewTask.IdleBorderRadius = 10;
            this.btnViewTask.IdleBorderThickness = 1;
            this.btnViewTask.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnViewTask.IdleIconLeftImage = null;
            this.btnViewTask.IdleIconRightImage = null;
            this.btnViewTask.IndicateFocus = false;
            this.btnViewTask.Location = new System.Drawing.Point(356, 5);
            this.btnViewTask.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewTask.OnDisabledState.BorderRadius = 10;
            this.btnViewTask.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewTask.OnDisabledState.BorderThickness = 1;
            this.btnViewTask.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewTask.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewTask.OnDisabledState.IconLeftImage = null;
            this.btnViewTask.OnDisabledState.IconRightImage = null;
            this.btnViewTask.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnViewTask.onHoverState.BorderRadius = 10;
            this.btnViewTask.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewTask.onHoverState.BorderThickness = 1;
            this.btnViewTask.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnViewTask.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnViewTask.onHoverState.IconLeftImage = null;
            this.btnViewTask.onHoverState.IconRightImage = null;
            this.btnViewTask.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnViewTask.OnIdleState.BorderRadius = 10;
            this.btnViewTask.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewTask.OnIdleState.BorderThickness = 1;
            this.btnViewTask.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnViewTask.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnViewTask.OnIdleState.IconLeftImage = null;
            this.btnViewTask.OnIdleState.IconRightImage = null;
            this.btnViewTask.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnViewTask.OnPressedState.BorderRadius = 10;
            this.btnViewTask.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewTask.OnPressedState.BorderThickness = 1;
            this.btnViewTask.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnViewTask.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnViewTask.OnPressedState.IconLeftImage = null;
            this.btnViewTask.OnPressedState.IconRightImage = null;
            this.btnViewTask.Size = new System.Drawing.Size(111, 30);
            this.btnViewTask.TabIndex = 8;
            this.btnViewTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewTask.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewTask.TextMarginLeft = 0;
            this.btnViewTask.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewTask.UseDefaultRadiusAndThickness = true;
            this.btnViewTask.Click += new System.EventHandler(this.btnViewTask_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlAssign);
            this.pnlBody.Controls.Add(this.dtgvTeams);
            this.pnlBody.Controls.Add(this.tbpnlButton);
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 125);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(637, 475);
            this.pnlBody.TabIndex = 8;
            // 
            // pnlAssign
            // 
            this.pnlAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.pnlAssign.Controls.Add(this.panel2);
            this.pnlAssign.Controls.Add(this.btnSave);
            this.pnlAssign.Controls.Add(this.cmbTeamList);
            this.pnlAssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlAssign.Location = new System.Drawing.Point(347, 38);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(290, 153);
            this.pnlAssign.TabIndex = 6;
            this.pnlAssign.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 30);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(290, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Team";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnSave.IdleBorderRadius = 10;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(19, 95);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 10;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnSave.onHoverState.BorderRadius = 10;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnSave.OnIdleState.BorderRadius = 10;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnSave.OnPressedState.BorderRadius = 10;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(260, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTeamList
            // 
            this.cmbTeamList.FormattingEnabled = true;
            this.cmbTeamList.Items.AddRange(new object[] {
            "Team A",
            "Team B",
            "Team C"});
            this.cmbTeamList.Location = new System.Drawing.Point(19, 56);
            this.cmbTeamList.Name = "cmbTeamList";
            this.cmbTeamList.Size = new System.Drawing.Size(260, 31);
            this.cmbTeamList.TabIndex = 11;
            // 
            // dtgvTeams
            // 
            this.dtgvTeams.AllowCustomTheming = false;
            this.dtgvTeams.AllowUserToAddRows = false;
            this.dtgvTeams.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvTeams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTeams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTeams.ColumnHeadersHeight = 40;
            this.dtgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_id,
            this.project_id,
            this.team_lead_id,
            this.name,
            this.abbreviation,
            this.team_lead_name});
            this.dtgvTeams.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvTeams.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvTeams.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvTeams.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvTeams.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvTeams.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvTeams.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvTeams.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvTeams.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvTeams.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTeams.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgvTeams.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvTeams.CurrentTheme.Name = null;
            this.dtgvTeams.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTeams.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvTeams.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvTeams.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvTeams.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTeams.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTeams.EnableHeadersVisualStyles = false;
            this.dtgvTeams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvTeams.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvTeams.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvTeams.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvTeams.Location = new System.Drawing.Point(0, 40);
            this.dtgvTeams.Name = "dtgvTeams";
            this.dtgvTeams.ReadOnly = true;
            this.dtgvTeams.RowHeadersVisible = false;
            this.dtgvTeams.RowHeadersWidth = 51;
            this.dtgvTeams.RowTemplate.Height = 40;
            this.dtgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTeams.Size = new System.Drawing.Size(637, 375);
            this.dtgvTeams.TabIndex = 0;
            this.dtgvTeams.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // team_id
            // 
            this.team_id.DataPropertyName = "team_id";
            this.team_id.HeaderText = "Id";
            this.team_id.MinimumWidth = 6;
            this.team_id.Name = "team_id";
            this.team_id.ReadOnly = true;
            this.team_id.Visible = false;
            // 
            // project_id
            // 
            this.project_id.DataPropertyName = "project_id";
            this.project_id.HeaderText = "Project Id";
            this.project_id.MinimumWidth = 6;
            this.project_id.Name = "project_id";
            this.project_id.ReadOnly = true;
            this.project_id.Visible = false;
            // 
            // team_lead_id
            // 
            this.team_lead_id.DataPropertyName = "team_lead_id";
            this.team_lead_id.HeaderText = "Team Lead ID";
            this.team_lead_id.MinimumWidth = 6;
            this.team_lead_id.Name = "team_lead_id";
            this.team_lead_id.ReadOnly = true;
            this.team_lead_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // abbreviation
            // 
            this.abbreviation.DataPropertyName = "abbreviation";
            this.abbreviation.HeaderText = "Abbreviation";
            this.abbreviation.MinimumWidth = 6;
            this.abbreviation.Name = "abbreviation";
            this.abbreviation.ReadOnly = true;
            // 
            // team_lead_name
            // 
            this.team_lead_name.DataPropertyName = "team_lead_name";
            this.team_lead_name.HeaderText = "Team Lead";
            this.team_lead_name.MinimumWidth = 6;
            this.team_lead_name.Name = "team_lead_name";
            this.team_lead_name.ReadOnly = true;
            // 
            // tbpnlButton
            // 
            this.tbpnlButton.ColumnCount = 3;
            this.tbpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbpnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpnlButton.Controls.Add(this.btnDelete, 0, 0);
            this.tbpnlButton.Controls.Add(this.btnUpdate, 1, 0);
            this.tbpnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbpnlButton.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tbpnlButton.Location = new System.Drawing.Point(0, 415);
            this.tbpnlButton.Name = "tbpnlButton";
            this.tbpnlButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpnlButton.RowCount = 1;
            this.tbpnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnlButton.Size = new System.Drawing.Size(637, 60);
            this.tbpnlButton.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges2;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDelete.IdleBorderRadius = 10;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(537, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 10;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.btnDelete.onHoverState.BorderRadius = 10;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDelete.OnIdleState.BorderRadius = 10;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.btnDelete.OnPressedState.BorderRadius = 10;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(189)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowAnimations = true;
            this.btnUpdate.AllowMouseEffects = true;
            this.btnUpdate.AllowToggling = false;
            this.btnUpdate.AnimationSpeed = 200;
            this.btnUpdate.AutoGenerateColors = false;
            this.btnUpdate.AutoRoundBorders = false;
            this.btnUpdate.AutoSizeLeftIcon = true;
            this.btnUpdate.AutoSizeRightIcon = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.ButtonTextMarginLeft = 0;
            this.btnUpdate.ColorContrastOnClick = 45;
            this.btnUpdate.ColorContrastOnHover = 45;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnUpdate.CustomizableEdges = borderEdges3;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpdate.IconMarginLeft = 11;
            this.btnUpdate.IconPadding = 10;
            this.btnUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnUpdate.IdleBorderRadius = 10;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnUpdate.IdleIconLeftImage = null;
            this.btnUpdate.IdleIconRightImage = null;
            this.btnUpdate.IndicateFocus = false;
            this.btnUpdate.Location = new System.Drawing.Point(437, 10);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpdate.OnDisabledState.BorderRadius = 10;
            this.btnUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnDisabledState.BorderThickness = 1;
            this.btnUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdate.OnDisabledState.IconLeftImage = null;
            this.btnUpdate.OnDisabledState.IconRightImage = null;
            this.btnUpdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnUpdate.onHoverState.BorderRadius = 10;
            this.btnUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.onHoverState.BorderThickness = 1;
            this.btnUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnUpdate.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUpdate.onHoverState.IconLeftImage = null;
            this.btnUpdate.onHoverState.IconRightImage = null;
            this.btnUpdate.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnUpdate.OnIdleState.BorderRadius = 10;
            this.btnUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnIdleState.BorderThickness = 1;
            this.btnUpdate.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnUpdate.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnUpdate.OnIdleState.IconLeftImage = null;
            this.btnUpdate.OnIdleState.IconRightImage = null;
            this.btnUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnUpdate.OnPressedState.BorderRadius = 10;
            this.btnUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdate.OnPressedState.BorderThickness = 1;
            this.btnUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnUpdate.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnUpdate.OnPressedState.IconLeftImage = null;
            this.btnUpdate.OnPressedState.IconRightImage = null;
            this.btnUpdate.Size = new System.Drawing.Size(90, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextMarginLeft = 0;
            this.btnUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpdate.UseDefaultRadiusAndThickness = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewTask);
            this.panel1.Controls.Add(this.btnAssignTeam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(637, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnAssignTeam
            // 
            this.btnAssignTeam.AllowAnimations = true;
            this.btnAssignTeam.AllowMouseEffects = true;
            this.btnAssignTeam.AllowToggling = false;
            this.btnAssignTeam.AnimationSpeed = 200;
            this.btnAssignTeam.AutoGenerateColors = false;
            this.btnAssignTeam.AutoRoundBorders = false;
            this.btnAssignTeam.AutoSizeLeftIcon = true;
            this.btnAssignTeam.AutoSizeRightIcon = true;
            this.btnAssignTeam.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignTeam.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAssignTeam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssignTeam.BackgroundImage")));
            this.btnAssignTeam.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAssignTeam.ButtonText = "Assign Team";
            this.btnAssignTeam.ButtonTextMarginLeft = 0;
            this.btnAssignTeam.ColorContrastOnClick = 45;
            this.btnAssignTeam.ColorContrastOnHover = 45;
            this.btnAssignTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAssignTeam.CustomizableEdges = borderEdges5;
            this.btnAssignTeam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAssignTeam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAssignTeam.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAssignTeam.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAssignTeam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAssignTeam.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAssignTeam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAssignTeam.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignTeam.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAssignTeam.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAssignTeam.IconMarginLeft = 11;
            this.btnAssignTeam.IconPadding = 10;
            this.btnAssignTeam.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignTeam.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAssignTeam.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAssignTeam.IconSize = 25;
            this.btnAssignTeam.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAssignTeam.IdleBorderRadius = 10;
            this.btnAssignTeam.IdleBorderThickness = 1;
            this.btnAssignTeam.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAssignTeam.IdleIconLeftImage = null;
            this.btnAssignTeam.IdleIconRightImage = null;
            this.btnAssignTeam.IndicateFocus = false;
            this.btnAssignTeam.Location = new System.Drawing.Point(480, 5);
            this.btnAssignTeam.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnAssignTeam.Name = "btnAssignTeam";
            this.btnAssignTeam.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAssignTeam.OnDisabledState.BorderRadius = 10;
            this.btnAssignTeam.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAssignTeam.OnDisabledState.BorderThickness = 1;
            this.btnAssignTeam.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAssignTeam.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAssignTeam.OnDisabledState.IconLeftImage = null;
            this.btnAssignTeam.OnDisabledState.IconRightImage = null;
            this.btnAssignTeam.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnAssignTeam.onHoverState.BorderRadius = 10;
            this.btnAssignTeam.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAssignTeam.onHoverState.BorderThickness = 1;
            this.btnAssignTeam.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.btnAssignTeam.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAssignTeam.onHoverState.IconLeftImage = null;
            this.btnAssignTeam.onHoverState.IconRightImage = null;
            this.btnAssignTeam.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAssignTeam.OnIdleState.BorderRadius = 10;
            this.btnAssignTeam.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAssignTeam.OnIdleState.BorderThickness = 1;
            this.btnAssignTeam.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAssignTeam.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAssignTeam.OnIdleState.IconLeftImage = null;
            this.btnAssignTeam.OnIdleState.IconRightImage = null;
            this.btnAssignTeam.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnAssignTeam.OnPressedState.BorderRadius = 10;
            this.btnAssignTeam.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAssignTeam.OnPressedState.BorderThickness = 1;
            this.btnAssignTeam.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(229)))), ((int)(((byte)(222)))));
            this.btnAssignTeam.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAssignTeam.OnPressedState.IconLeftImage = null;
            this.btnAssignTeam.OnPressedState.IconRightImage = null;
            this.btnAssignTeam.Size = new System.Drawing.Size(147, 30);
            this.btnAssignTeam.TabIndex = 8;
            this.btnAssignTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAssignTeam.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAssignTeam.TextMarginLeft = 0;
            this.btnAssignTeam.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAssignTeam.UseDefaultRadiusAndThickness = true;
            this.btnAssignTeam.Click += new System.EventHandler(this.btnAssignTeam_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teams";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProjectDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(637, 600);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlWindowTools);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjectDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProjectDetail";
            this.Load += new System.EventHandler(this.frmProjectDetail_Load);
            this.pnlWindowTools.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlAssign.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeams)).EndInit();
            this.tbpnlButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWindowTools;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuImageButton btnHide;
        private Bunifu.UI.WinForms.BunifuImageButton btnMax;
        private Bunifu.UI.WinForms.BunifuImageButton btnQuit;
        private Bunifu.Framework.UI.BunifuDragControl dragProjectDetailForm;
        private Bunifu.Framework.UI.BunifuElipse roundedProjectDetailForm;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private Bunifu.UI.WinForms.BunifuTextBox txbProjectName;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvTeams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDeadline;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAssignTeam;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewTask;
        private System.Windows.Forms.TableLayoutPanel tbpnlButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.UI.WinForms.BunifuDatePicker dpCreateAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_lead_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_lead_name;
        private System.Windows.Forms.Panel pnlAssign;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private System.Windows.Forms.ComboBox cmbTeamList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}