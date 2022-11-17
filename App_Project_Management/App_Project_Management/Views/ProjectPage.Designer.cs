namespace App_Project_Management.Views
{
    partial class ProjectPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectPage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlProjectTabHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProjectTabBody = new System.Windows.Forms.Panel();
            this.tbpnlProject = new System.Windows.Forms.TableLayoutPanel();
            this.VScrollBar = new System.Windows.Forms.VScrollBar();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.btnPreviousPage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNextPage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlProjectTableHeader = new System.Windows.Forms.Panel();
            this.pnlProjectTableFilter = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddProject = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlProjectTabHeader.SuspendLayout();
            this.pnlProjectTabBody.SuspendLayout();
            this.tbpnlProject.SuspendLayout();
            this.pnlPaging.SuspendLayout();
            this.pnlProjectTableHeader.SuspendLayout();
            this.pnlProjectTableFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjectTabHeader
            // 
            this.pnlProjectTabHeader.Controls.Add(this.label1);
            this.pnlProjectTabHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectTabHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectTabHeader.Name = "pnlProjectTabHeader";
            this.pnlProjectTabHeader.Size = new System.Drawing.Size(1058, 50);
            this.pnlProjectTabHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProjectTabBody
            // 
            this.pnlProjectTabBody.Controls.Add(this.tbpnlProject);
            this.pnlProjectTabBody.Controls.Add(this.pnlPaging);
            this.pnlProjectTabBody.Controls.Add(this.pnlTable);
            this.pnlProjectTabBody.Controls.Add(this.pnlProjectTableHeader);
            this.pnlProjectTabBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectTabBody.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProjectTabBody.Location = new System.Drawing.Point(0, 50);
            this.pnlProjectTabBody.Name = "pnlProjectTabBody";
            this.pnlProjectTabBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlProjectTabBody.Size = new System.Drawing.Size(1058, 660);
            this.pnlProjectTabBody.TabIndex = 5;
            // 
            // tbpnlProject
            // 
            this.tbpnlProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tbpnlProject.ColumnCount = 3;
            this.tbpnlProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnlProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnlProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnlProject.Controls.Add(this.VScrollBar, 2, 0);
            this.tbpnlProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnlProject.Location = new System.Drawing.Point(10, 70);
            this.tbpnlProject.Margin = new System.Windows.Forms.Padding(0);
            this.tbpnlProject.Name = "tbpnlProject";
            this.tbpnlProject.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tbpnlProject.RowCount = 2;
            this.tbpnlProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpnlProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpnlProject.Size = new System.Drawing.Size(1038, 550);
            this.tbpnlProject.TabIndex = 6;
            // 
            // VScrollBar
            // 
            this.VScrollBar.Location = new System.Drawing.Point(692, 5);
            this.VScrollBar.Name = "VScrollBar";
            this.VScrollBar.Size = new System.Drawing.Size(40, 117);
            this.VScrollBar.TabIndex = 0;
            this.VScrollBar.Visible = false;
            this.VScrollBar.ValueChanged += new System.EventHandler(this.VScrollBar_ValueChanged);
            // 
            // pnlPaging
            // 
            this.pnlPaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlPaging.Controls.Add(this.btnPreviousPage);
            this.pnlPaging.Controls.Add(this.btnNextPage);
            this.pnlPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaging.Location = new System.Drawing.Point(10, 620);
            this.pnlPaging.Name = "pnlPaging";
            this.pnlPaging.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlPaging.Size = new System.Drawing.Size(1038, 30);
            this.pnlPaging.TabIndex = 7;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.ActiveImage = null;
            this.btnPreviousPage.AllowAnimations = true;
            this.btnPreviousPage.AllowBuffering = false;
            this.btnPreviousPage.AllowToggling = false;
            this.btnPreviousPage.AllowZooming = true;
            this.btnPreviousPage.AllowZoomingOnFocus = false;
            this.btnPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPreviousPage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.ErrorImage")));
            this.btnPreviousPage.FadeWhenInactive = false;
            this.btnPreviousPage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageActive = null;
            this.btnPreviousPage.ImageLocation = null;
            this.btnPreviousPage.ImageMargin = 0;
            this.btnPreviousPage.ImageSize = new System.Drawing.Size(29, 29);
            this.btnPreviousPage.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnPreviousPage.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.InitialImage")));
            this.btnPreviousPage.Location = new System.Drawing.Point(950, 2);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Rotation = 0;
            this.btnPreviousPage.ShowActiveImage = true;
            this.btnPreviousPage.ShowCursorChanges = true;
            this.btnPreviousPage.ShowImageBorders = false;
            this.btnPreviousPage.ShowSizeMarkers = false;
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousPage.TabIndex = 1;
            this.btnPreviousPage.ToolTipText = "";
            this.btnPreviousPage.WaitOnLoad = false;
            this.btnPreviousPage.Zoom = 0;
            this.btnPreviousPage.ZoomSpeed = 10;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.ActiveImage = null;
            this.btnNextPage.AllowAnimations = true;
            this.btnNextPage.AllowBuffering = false;
            this.btnNextPage.AllowToggling = false;
            this.btnNextPage.AllowZooming = true;
            this.btnNextPage.AllowZoomingOnFocus = false;
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextPage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.ErrorImage")));
            this.btnNextPage.FadeWhenInactive = false;
            this.btnNextPage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageActive = null;
            this.btnNextPage.ImageLocation = null;
            this.btnNextPage.ImageMargin = 0;
            this.btnNextPage.ImageSize = new System.Drawing.Size(29, 29);
            this.btnNextPage.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnNextPage.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.InitialImage")));
            this.btnNextPage.Location = new System.Drawing.Point(993, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Rotation = 0;
            this.btnNextPage.ShowActiveImage = true;
            this.btnNextPage.ShowCursorChanges = true;
            this.btnNextPage.ShowImageBorders = false;
            this.btnNextPage.ShowSizeMarkers = false;
            this.btnNextPage.Size = new System.Drawing.Size(30, 30);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.ToolTipText = "";
            this.btnNextPage.WaitOnLoad = false;
            this.btnNextPage.Zoom = 0;
            this.btnNextPage.ZoomSpeed = 10;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTable.Location = new System.Drawing.Point(10, 60);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(50);
            this.pnlTable.Size = new System.Drawing.Size(1038, 10);
            this.pnlTable.TabIndex = 4;
            // 
            // pnlProjectTableHeader
            // 
            this.pnlProjectTableHeader.Controls.Add(this.pnlProjectTableFilter);
            this.pnlProjectTableHeader.Controls.Add(this.btnAddProject);
            this.pnlProjectTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectTableHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlProjectTableHeader.Name = "pnlProjectTableHeader";
            this.pnlProjectTableHeader.Size = new System.Drawing.Size(1038, 50);
            this.pnlProjectTableHeader.TabIndex = 2;
            // 
            // pnlProjectTableFilter
            // 
            this.pnlProjectTableFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlProjectTableFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProjectTableFilter.BackgroundImage")));
            this.pnlProjectTableFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProjectTableFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlProjectTableFilter.BorderRadius = 10;
            this.pnlProjectTableFilter.BorderThickness = 0;
            this.pnlProjectTableFilter.Controls.Add(this.bunifuImageButton2);
            this.pnlProjectTableFilter.Controls.Add(this.bunifuTextBox2);
            this.pnlProjectTableFilter.Controls.Add(this.button1);
            this.pnlProjectTableFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProjectTableFilter.Location = new System.Drawing.Point(172, 0);
            this.pnlProjectTableFilter.Name = "pnlProjectTableFilter";
            this.pnlProjectTableFilter.ShowBorders = true;
            this.pnlProjectTableFilter.Size = new System.Drawing.Size(866, 50);
            this.pnlProjectTableFilter.TabIndex = 2;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 0;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(29, 29);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(823, 10);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 0;
            this.bunifuImageButton2.ZoomSpeed = 10;
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AnimationSpeed = 200;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.bunifuTextBox2.BorderRadius = 5;
            this.bunifuTextBox2.BorderThickness = 1;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.IconLeft")));
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.Lines = new string[0];
            this.bunifuTextBox2.Location = new System.Drawing.Point(564, 5);
            this.bunifuTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Multiline = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            stateProperties37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox2.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            stateProperties40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnIdleState = stateProperties40;
            this.bunifuTextBox2.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox2.PlaceholderText = "Search ...";
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(244, 39);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 3;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginBottom = 0;
            this.bunifuTextBox2.TextMarginLeft = 10;
            this.bunifuTextBox2.TextMarginTop = 0;
            this.bunifuTextBox2.TextPlaceholder = "Search ...";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            this.bunifuTextBox2.WordWrap = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.button1.Location = new System.Drawing.Point(5, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddProject
            // 
            this.btnAddProject.AllowAnimations = true;
            this.btnAddProject.AllowMouseEffects = true;
            this.btnAddProject.AllowToggling = false;
            this.btnAddProject.AnimationSpeed = 200;
            this.btnAddProject.AutoGenerateColors = false;
            this.btnAddProject.AutoRoundBorders = false;
            this.btnAddProject.AutoSizeLeftIcon = true;
            this.btnAddProject.AutoSizeRightIcon = true;
            this.btnAddProject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProject.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddProject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProject.BackgroundImage")));
            this.btnAddProject.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProject.ButtonText = "Add Project";
            this.btnAddProject.ButtonTextMarginLeft = 0;
            this.btnAddProject.ColorContrastOnClick = 45;
            this.btnAddProject.ColorContrastOnHover = 45;
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnAddProject.CustomizableEdges = borderEdges10;
            this.btnAddProject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddProject.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddProject.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProject.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAddProject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddProject.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddProject.IconMarginLeft = 11;
            this.btnAddProject.IconPadding = 10;
            this.btnAddProject.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProject.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddProject.IconSize = 25;
            this.btnAddProject.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddProject.IdleBorderRadius = 20;
            this.btnAddProject.IdleBorderThickness = 1;
            this.btnAddProject.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddProject.IdleIconLeftImage = null;
            this.btnAddProject.IdleIconRightImage = null;
            this.btnAddProject.IndicateFocus = false;
            this.btnAddProject.Location = new System.Drawing.Point(0, 0);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddProject.OnDisabledState.BorderRadius = 20;
            this.btnAddProject.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProject.OnDisabledState.BorderThickness = 1;
            this.btnAddProject.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddProject.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddProject.OnDisabledState.IconLeftImage = null;
            this.btnAddProject.OnDisabledState.IconRightImage = null;
            this.btnAddProject.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddProject.onHoverState.BorderRadius = 20;
            this.btnAddProject.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProject.onHoverState.BorderThickness = 1;
            this.btnAddProject.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddProject.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.onHoverState.IconLeftImage = null;
            this.btnAddProject.onHoverState.IconRightImage = null;
            this.btnAddProject.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddProject.OnIdleState.BorderRadius = 20;
            this.btnAddProject.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProject.OnIdleState.BorderThickness = 1;
            this.btnAddProject.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddProject.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddProject.OnIdleState.IconLeftImage = null;
            this.btnAddProject.OnIdleState.IconRightImage = null;
            this.btnAddProject.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddProject.OnPressedState.BorderRadius = 20;
            this.btnAddProject.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProject.OnPressedState.BorderThickness = 1;
            this.btnAddProject.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddProject.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.OnPressedState.IconLeftImage = null;
            this.btnAddProject.OnPressedState.IconRightImage = null;
            this.btnAddProject.Size = new System.Drawing.Size(145, 50);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProject.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProject.TextMarginLeft = 0;
            this.btnAddProject.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddProject.UseDefaultRadiusAndThickness = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // ProjectPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlProjectTabBody);
            this.Controls.Add(this.pnlProjectTabHeader);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.Name = "ProjectPage";
            this.Size = new System.Drawing.Size(1058, 710);
            this.Load += new System.EventHandler(this.ProjectPage_Load);
            this.pnlProjectTabHeader.ResumeLayout(false);
            this.pnlProjectTabBody.ResumeLayout(false);
            this.tbpnlProject.ResumeLayout(false);
            this.pnlPaging.ResumeLayout(false);
            this.pnlProjectTableHeader.ResumeLayout(false);
            this.pnlProjectTableFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProjectTabHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProjectTabBody;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel pnlProjectTableHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlProjectTableFilter;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox2;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddProject;
        private System.Windows.Forms.TableLayoutPanel tbpnlProject;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel pnlPaging;
        private Bunifu.UI.WinForms.BunifuImageButton btnPreviousPage;
        private Bunifu.UI.WinForms.BunifuImageButton btnNextPage;
        private System.Windows.Forms.VScrollBar VScrollBar;
    }
}
