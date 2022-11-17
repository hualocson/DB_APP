namespace App_Project_Management.Views
{
    partial class CompanyPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyPage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlCompanyTabHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCompanyTabBody = new System.Windows.Forms.Panel();
            this.dtgvCompany = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlCompanyTableHeader = new System.Windows.Forms.Panel();
            this.pnlCompanyTableFilter = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCompany = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlCompanyTabHeader.SuspendLayout();
            this.pnlCompanyTabBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompany)).BeginInit();
            this.pnlCompanyTableHeader.SuspendLayout();
            this.pnlCompanyTableFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCompanyTabHeader
            // 
            this.pnlCompanyTabHeader.Controls.Add(this.label1);
            this.pnlCompanyTabHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompanyTabHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCompanyTabHeader.Name = "pnlCompanyTabHeader";
            this.pnlCompanyTabHeader.Size = new System.Drawing.Size(1058, 50);
            this.pnlCompanyTabHeader.TabIndex = 3;
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
            this.label1.Text = "Companies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCompanyTabBody
            // 
            this.pnlCompanyTabBody.Controls.Add(this.dtgvCompany);
            this.pnlCompanyTabBody.Controls.Add(this.pnlTable);
            this.pnlCompanyTabBody.Controls.Add(this.pnlCompanyTableHeader);
            this.pnlCompanyTabBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompanyTabBody.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCompanyTabBody.Location = new System.Drawing.Point(0, 50);
            this.pnlCompanyTabBody.Name = "pnlCompanyTabBody";
            this.pnlCompanyTabBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCompanyTabBody.Size = new System.Drawing.Size(1058, 660);
            this.pnlCompanyTabBody.TabIndex = 4;
            // 
            // dtgvCompany
            // 
            this.dtgvCompany.AllowCustomTheming = false;
            this.dtgvCompany.AllowUserToAddRows = false;
            this.dtgvCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCompany.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCompany.ColumnHeadersHeight = 40;
            this.dtgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_name,
            this.company_abbreviation,
            this.company_address,
            this.company_phone,
            this.id});
            this.dtgvCompany.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvCompany.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvCompany.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvCompany.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvCompany.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvCompany.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvCompany.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvCompany.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvCompany.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvCompany.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvCompany.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgvCompany.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvCompany.CurrentTheme.Name = null;
            this.dtgvCompany.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCompany.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvCompany.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvCompany.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvCompany.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCompany.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCompany.EnableHeadersVisualStyles = false;
            this.dtgvCompany.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvCompany.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvCompany.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvCompany.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvCompany.Location = new System.Drawing.Point(10, 70);
            this.dtgvCompany.Name = "dtgvCompany";
            this.dtgvCompany.ReadOnly = true;
            this.dtgvCompany.RowHeadersVisible = false;
            this.dtgvCompany.RowHeadersWidth = 51;
            this.dtgvCompany.RowTemplate.Height = 40;
            this.dtgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCompany.Size = new System.Drawing.Size(1038, 580);
            this.dtgvCompany.TabIndex = 5;
            this.dtgvCompany.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCompany_CellClick);
            // 
            // company_name
            // 
            this.company_name.DataPropertyName = "name";
            this.company_name.HeaderText = "Company";
            this.company_name.MinimumWidth = 6;
            this.company_name.Name = "company_name";
            this.company_name.ReadOnly = true;
            // 
            // company_abbreviation
            // 
            this.company_abbreviation.DataPropertyName = "abbreviation";
            this.company_abbreviation.HeaderText = "Abbreviation";
            this.company_abbreviation.MinimumWidth = 6;
            this.company_abbreviation.Name = "company_abbreviation";
            this.company_abbreviation.ReadOnly = true;
            // 
            // company_address
            // 
            this.company_address.DataPropertyName = "address";
            this.company_address.HeaderText = "Address";
            this.company_address.MinimumWidth = 6;
            this.company_address.Name = "company_address";
            this.company_address.ReadOnly = true;
            // 
            // company_phone
            // 
            this.company_phone.DataPropertyName = "phone";
            this.company_phone.HeaderText = "Phone";
            this.company_phone.MinimumWidth = 6;
            this.company_phone.Name = "company_phone";
            this.company_phone.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // pnlCompanyTableHeader
            // 
            this.pnlCompanyTableHeader.Controls.Add(this.pnlCompanyTableFilter);
            this.pnlCompanyTableHeader.Controls.Add(this.btnAddCompany);
            this.pnlCompanyTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompanyTableHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlCompanyTableHeader.Name = "pnlCompanyTableHeader";
            this.pnlCompanyTableHeader.Size = new System.Drawing.Size(1038, 50);
            this.pnlCompanyTableHeader.TabIndex = 2;
            // 
            // pnlCompanyTableFilter
            // 
            this.pnlCompanyTableFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlCompanyTableFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCompanyTableFilter.BackgroundImage")));
            this.pnlCompanyTableFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCompanyTableFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlCompanyTableFilter.BorderRadius = 10;
            this.pnlCompanyTableFilter.BorderThickness = 0;
            this.pnlCompanyTableFilter.Controls.Add(this.bunifuTextBox2);
            this.pnlCompanyTableFilter.Controls.Add(this.bunifuImageButton1);
            this.pnlCompanyTableFilter.Controls.Add(this.button1);
            this.pnlCompanyTableFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCompanyTableFilter.Location = new System.Drawing.Point(172, 0);
            this.pnlCompanyTableFilter.Name = "pnlCompanyTableFilter";
            this.pnlCompanyTableFilter.ShowBorders = true;
            this.pnlCompanyTableFilter.Size = new System.Drawing.Size(866, 50);
            this.pnlCompanyTableFilter.TabIndex = 2;
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox2.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.OnIdleState = stateProperties4;
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
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(29, 29);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(823, 10);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
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
            // btnAddCompany
            // 
            this.btnAddCompany.AllowAnimations = true;
            this.btnAddCompany.AllowMouseEffects = true;
            this.btnAddCompany.AllowToggling = false;
            this.btnAddCompany.AnimationSpeed = 200;
            this.btnAddCompany.AutoGenerateColors = false;
            this.btnAddCompany.AutoRoundBorders = false;
            this.btnAddCompany.AutoSizeLeftIcon = true;
            this.btnAddCompany.AutoSizeRightIcon = true;
            this.btnAddCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCompany.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.BackgroundImage")));
            this.btnAddCompany.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCompany.ButtonText = "Add Company";
            this.btnAddCompany.ButtonTextMarginLeft = 0;
            this.btnAddCompany.ColorContrastOnClick = 45;
            this.btnAddCompany.ColorContrastOnHover = 45;
            this.btnAddCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddCompany.CustomizableEdges = borderEdges1;
            this.btnAddCompany.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCompany.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCompany.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCompany.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCompany.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddCompany.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAddCompany.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddCompany.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCompany.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCompany.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddCompany.IconMarginLeft = 11;
            this.btnAddCompany.IconPadding = 10;
            this.btnAddCompany.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCompany.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCompany.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddCompany.IconSize = 25;
            this.btnAddCompany.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddCompany.IdleBorderRadius = 20;
            this.btnAddCompany.IdleBorderThickness = 1;
            this.btnAddCompany.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddCompany.IdleIconLeftImage = null;
            this.btnAddCompany.IdleIconRightImage = null;
            this.btnAddCompany.IndicateFocus = false;
            this.btnAddCompany.Location = new System.Drawing.Point(0, 0);
            this.btnAddCompany.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCompany.OnDisabledState.BorderRadius = 20;
            this.btnAddCompany.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCompany.OnDisabledState.BorderThickness = 1;
            this.btnAddCompany.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCompany.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCompany.OnDisabledState.IconLeftImage = null;
            this.btnAddCompany.OnDisabledState.IconRightImage = null;
            this.btnAddCompany.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddCompany.onHoverState.BorderRadius = 20;
            this.btnAddCompany.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCompany.onHoverState.BorderThickness = 1;
            this.btnAddCompany.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddCompany.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddCompany.onHoverState.IconLeftImage = null;
            this.btnAddCompany.onHoverState.IconRightImage = null;
            this.btnAddCompany.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddCompany.OnIdleState.BorderRadius = 20;
            this.btnAddCompany.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCompany.OnIdleState.BorderThickness = 1;
            this.btnAddCompany.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddCompany.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddCompany.OnIdleState.IconLeftImage = null;
            this.btnAddCompany.OnIdleState.IconRightImage = null;
            this.btnAddCompany.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddCompany.OnPressedState.BorderRadius = 20;
            this.btnAddCompany.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCompany.OnPressedState.BorderThickness = 1;
            this.btnAddCompany.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddCompany.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddCompany.OnPressedState.IconLeftImage = null;
            this.btnAddCompany.OnPressedState.IconRightImage = null;
            this.btnAddCompany.Size = new System.Drawing.Size(145, 50);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCompany.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCompany.TextMarginLeft = 0;
            this.btnAddCompany.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddCompany.UseDefaultRadiusAndThickness = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // CompanyPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlCompanyTabBody);
            this.Controls.Add(this.pnlCompanyTabHeader);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.Name = "CompanyPage";
            this.Size = new System.Drawing.Size(1058, 710);
            this.Load += new System.EventHandler(this.CompanyPage_Load);
            this.pnlCompanyTabHeader.ResumeLayout(false);
            this.pnlCompanyTabBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompany)).EndInit();
            this.pnlCompanyTableHeader.ResumeLayout(false);
            this.pnlCompanyTableFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompanyTabHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCompanyTabBody;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel pnlCompanyTableHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlCompanyTableFilter;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCompany;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_abbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
