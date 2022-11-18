namespace App_Project_Management.Views
{
    partial class MemberPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlMemberTabHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dtgvMember = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlMemberTableHeader = new System.Windows.Forms.Panel();
            this.btnInvite = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlMemberTableFilter = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txbsearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddMember = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlMemberTabHeader.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).BeginInit();
            this.pnlMemberTableHeader.SuspendLayout();
            this.pnlMemberTableFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMemberTabHeader
            // 
            this.pnlMemberTabHeader.Controls.Add(this.label1);
            this.pnlMemberTabHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMemberTabHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMemberTabHeader.Name = "pnlMemberTabHeader";
            this.pnlMemberTabHeader.Size = new System.Drawing.Size(1058, 50);
            this.pnlMemberTabHeader.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(152, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dtgvMember);
            this.panel.Controls.Add(this.pnlTable);
            this.panel.Controls.Add(this.pnlMemberTableHeader);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(0, 50);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(10);
            this.panel.Size = new System.Drawing.Size(1058, 660);
            this.panel.TabIndex = 6;
            // 
            // dtgvMember
            // 
            this.dtgvMember.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMember.ColumnHeadersHeight = 40;
            this.dtgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.member_name,
            this.gender,
            this.role_id,
            this.team_id,
            this.team_name,
            this.member_email,
            this.password,
            this.company_id,
            this.member_role,
            this.company_name,
            this.abbreviation});
            this.dtgvMember.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvMember.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvMember.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvMember.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvMember.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvMember.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvMember.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvMember.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvMember.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvMember.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvMember.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgvMember.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMember.CurrentTheme.Name = null;
            this.dtgvMember.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMember.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvMember.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvMember.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvMember.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMember.EnableHeadersVisualStyles = false;
            this.dtgvMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvMember.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvMember.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvMember.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvMember.Location = new System.Drawing.Point(10, 70);
            this.dtgvMember.Name = "dtgvMember";
            this.dtgvMember.RowHeadersVisible = false;
            this.dtgvMember.RowHeadersWidth = 51;
            this.dtgvMember.RowTemplate.Height = 40;
            this.dtgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMember.Size = new System.Drawing.Size(1038, 580);
            this.dtgvMember.TabIndex = 6;
            this.dtgvMember.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMember_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // member_name
            // 
            this.member_name.DataPropertyName = "name";
            this.member_name.HeaderText = "Name";
            this.member_name.MinimumWidth = 6;
            this.member_name.Name = "member_name";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.Visible = false;
            // 
            // role_id
            // 
            this.role_id.DataPropertyName = "role_id";
            this.role_id.HeaderText = "role_id";
            this.role_id.MinimumWidth = 6;
            this.role_id.Name = "role_id";
            this.role_id.Visible = false;
            // 
            // team_id
            // 
            this.team_id.DataPropertyName = "team_id";
            this.team_id.HeaderText = "team_id";
            this.team_id.MinimumWidth = 6;
            this.team_id.Name = "team_id";
            this.team_id.Visible = false;
            // 
            // team_name
            // 
            this.team_name.DataPropertyName = "team_name";
            this.team_name.HeaderText = "Team";
            this.team_name.MinimumWidth = 6;
            this.team_name.Name = "team_name";
            // 
            // member_email
            // 
            this.member_email.DataPropertyName = "username";
            this.member_email.HeaderText = "Email";
            this.member_email.MinimumWidth = 6;
            this.member_email.Name = "member_email";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // company_id
            // 
            this.company_id.DataPropertyName = "company_id";
            this.company_id.HeaderText = "company_id";
            this.company_id.MinimumWidth = 6;
            this.company_id.Name = "company_id";
            this.company_id.Visible = false;
            // 
            // member_role
            // 
            this.member_role.DataPropertyName = "role";
            this.member_role.HeaderText = "Role";
            this.member_role.MinimumWidth = 6;
            this.member_role.Name = "member_role";
            // 
            // company_name
            // 
            this.company_name.DataPropertyName = "company_name";
            this.company_name.HeaderText = "Company";
            this.company_name.MinimumWidth = 6;
            this.company_name.Name = "company_name";
            // 
            // abbreviation
            // 
            this.abbreviation.DataPropertyName = "abbreviation";
            this.abbreviation.HeaderText = "Abbreviation";
            this.abbreviation.MinimumWidth = 6;
            this.abbreviation.Name = "abbreviation";
            this.abbreviation.Visible = false;
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
            // pnlMemberTableHeader
            // 
            this.pnlMemberTableHeader.Controls.Add(this.btnInvite);
            this.pnlMemberTableHeader.Controls.Add(this.pnlMemberTableFilter);
            this.pnlMemberTableHeader.Controls.Add(this.btnAddMember);
            this.pnlMemberTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMemberTableHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlMemberTableHeader.Name = "pnlMemberTableHeader";
            this.pnlMemberTableHeader.Size = new System.Drawing.Size(1038, 50);
            this.pnlMemberTableHeader.TabIndex = 2;
            // 
            // btnInvite
            // 
            this.btnInvite.AllowAnimations = true;
            this.btnInvite.AllowMouseEffects = true;
            this.btnInvite.AllowToggling = false;
            this.btnInvite.AnimationSpeed = 200;
            this.btnInvite.AutoGenerateColors = false;
            this.btnInvite.AutoRoundBorders = false;
            this.btnInvite.AutoSizeLeftIcon = true;
            this.btnInvite.AutoSizeRightIcon = true;
            this.btnInvite.BackColor = System.Drawing.Color.Transparent;
            this.btnInvite.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnInvite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInvite.BackgroundImage")));
            this.btnInvite.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInvite.ButtonText = "Invite Member";
            this.btnInvite.ButtonTextMarginLeft = 0;
            this.btnInvite.ColorContrastOnClick = 45;
            this.btnInvite.ColorContrastOnHover = 45;
            this.btnInvite.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnInvite.CustomizableEdges = borderEdges1;
            this.btnInvite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInvite.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInvite.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInvite.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInvite.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnInvite.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnInvite.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvite.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvite.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInvite.IconMarginLeft = 11;
            this.btnInvite.IconPadding = 10;
            this.btnInvite.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvite.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvite.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInvite.IconSize = 25;
            this.btnInvite.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnInvite.IdleBorderRadius = 20;
            this.btnInvite.IdleBorderThickness = 1;
            this.btnInvite.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnInvite.IdleIconLeftImage = null;
            this.btnInvite.IdleIconRightImage = null;
            this.btnInvite.IndicateFocus = false;
            this.btnInvite.Location = new System.Drawing.Point(168, 0);
            this.btnInvite.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInvite.OnDisabledState.BorderRadius = 20;
            this.btnInvite.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInvite.OnDisabledState.BorderThickness = 1;
            this.btnInvite.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInvite.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInvite.OnDisabledState.IconLeftImage = null;
            this.btnInvite.OnDisabledState.IconRightImage = null;
            this.btnInvite.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInvite.onHoverState.BorderRadius = 20;
            this.btnInvite.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInvite.onHoverState.BorderThickness = 1;
            this.btnInvite.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnInvite.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInvite.onHoverState.IconLeftImage = null;
            this.btnInvite.onHoverState.IconRightImage = null;
            this.btnInvite.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnInvite.OnIdleState.BorderRadius = 20;
            this.btnInvite.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInvite.OnIdleState.BorderThickness = 1;
            this.btnInvite.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnInvite.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnInvite.OnIdleState.IconLeftImage = null;
            this.btnInvite.OnIdleState.IconRightImage = null;
            this.btnInvite.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInvite.OnPressedState.BorderRadius = 20;
            this.btnInvite.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInvite.OnPressedState.BorderThickness = 1;
            this.btnInvite.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInvite.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInvite.OnPressedState.IconLeftImage = null;
            this.btnInvite.OnPressedState.IconRightImage = null;
            this.btnInvite.Size = new System.Drawing.Size(149, 50);
            this.btnInvite.TabIndex = 3;
            this.btnInvite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvite.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInvite.TextMarginLeft = 0;
            this.btnInvite.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInvite.UseDefaultRadiusAndThickness = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // pnlMemberTableFilter
            // 
            this.pnlMemberTableFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlMemberTableFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMemberTableFilter.BackgroundImage")));
            this.pnlMemberTableFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMemberTableFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.pnlMemberTableFilter.BorderRadius = 10;
            this.pnlMemberTableFilter.BorderThickness = 0;
            this.pnlMemberTableFilter.Controls.Add(this.bunifuImageButton2);
            this.pnlMemberTableFilter.Controls.Add(this.txbsearch);
            this.pnlMemberTableFilter.Controls.Add(this.button1);
            this.pnlMemberTableFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMemberTableFilter.Location = new System.Drawing.Point(391, 0);
            this.pnlMemberTableFilter.Name = "pnlMemberTableFilter";
            this.pnlMemberTableFilter.ShowBorders = true;
            this.pnlMemberTableFilter.Size = new System.Drawing.Size(647, 50);
            this.pnlMemberTableFilter.TabIndex = 2;
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(599, 10);
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
            // txbsearch
            // 
            this.txbsearch.AcceptsReturn = false;
            this.txbsearch.AcceptsTab = false;
            this.txbsearch.AnimationSpeed = 200;
            this.txbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbsearch.BackColor = System.Drawing.Color.Transparent;
            this.txbsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbsearch.BackgroundImage")));
            this.txbsearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.txbsearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbsearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.txbsearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.txbsearch.BorderRadius = 5;
            this.txbsearch.BorderThickness = 1;
            this.txbsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbsearch.DefaultFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsearch.DefaultText = "";
            this.txbsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.txbsearch.HideSelection = true;
            this.txbsearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbsearch.IconLeft")));
            this.txbsearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbsearch.IconPadding = 10;
            this.txbsearch.IconRight = null;
            this.txbsearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbsearch.Lines = new string[0];
            this.txbsearch.Location = new System.Drawing.Point(325, 5);
            this.txbsearch.Margin = new System.Windows.Forms.Padding(5);
            this.txbsearch.MaxLength = 32767;
            this.txbsearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txbsearch.Modified = false;
            this.txbsearch.Multiline = false;
            this.txbsearch.Name = "txbsearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbsearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txbsearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbsearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbsearch.OnIdleState = stateProperties4;
            this.txbsearch.Padding = new System.Windows.Forms.Padding(3);
            this.txbsearch.PasswordChar = '\0';
            this.txbsearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbsearch.PlaceholderText = "Search ...";
            this.txbsearch.ReadOnly = false;
            this.txbsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbsearch.SelectedText = "";
            this.txbsearch.SelectionLength = 0;
            this.txbsearch.SelectionStart = 0;
            this.txbsearch.ShortcutsEnabled = true;
            this.txbsearch.Size = new System.Drawing.Size(244, 43);
            this.txbsearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txbsearch.TabIndex = 3;
            this.txbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbsearch.TextMarginBottom = 0;
            this.txbsearch.TextMarginLeft = 10;
            this.txbsearch.TextMarginTop = 0;
            this.txbsearch.TextPlaceholder = "Search ...";
            this.txbsearch.UseSystemPasswordChar = false;
            this.txbsearch.WordWrap = true;
            this.txbsearch.TextChange += new System.EventHandler(this.txbsearch_TextChange);
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
            // btnAddMember
            // 
            this.btnAddMember.AllowAnimations = true;
            this.btnAddMember.AllowMouseEffects = true;
            this.btnAddMember.AllowToggling = false;
            this.btnAddMember.AnimationSpeed = 200;
            this.btnAddMember.AutoGenerateColors = false;
            this.btnAddMember.AutoRoundBorders = false;
            this.btnAddMember.AutoSizeLeftIcon = true;
            this.btnAddMember.AutoSizeRightIcon = true;
            this.btnAddMember.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMember.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMember.BackgroundImage")));
            this.btnAddMember.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMember.ButtonText = "Add Member";
            this.btnAddMember.ButtonTextMarginLeft = 0;
            this.btnAddMember.ColorContrastOnClick = 45;
            this.btnAddMember.ColorContrastOnHover = 45;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddMember.CustomizableEdges = borderEdges2;
            this.btnAddMember.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMember.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMember.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMember.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddMember.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAddMember.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddMember.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddMember.IconMarginLeft = 11;
            this.btnAddMember.IconPadding = 10;
            this.btnAddMember.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddMember.IconSize = 25;
            this.btnAddMember.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddMember.IdleBorderRadius = 20;
            this.btnAddMember.IdleBorderThickness = 1;
            this.btnAddMember.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddMember.IdleIconLeftImage = null;
            this.btnAddMember.IdleIconRightImage = null;
            this.btnAddMember.IndicateFocus = false;
            this.btnAddMember.Location = new System.Drawing.Point(0, 0);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddMember.OnDisabledState.BorderRadius = 20;
            this.btnAddMember.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMember.OnDisabledState.BorderThickness = 1;
            this.btnAddMember.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddMember.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddMember.OnDisabledState.IconLeftImage = null;
            this.btnAddMember.OnDisabledState.IconRightImage = null;
            this.btnAddMember.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddMember.onHoverState.BorderRadius = 20;
            this.btnAddMember.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMember.onHoverState.BorderThickness = 1;
            this.btnAddMember.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddMember.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.onHoverState.IconLeftImage = null;
            this.btnAddMember.onHoverState.IconRightImage = null;
            this.btnAddMember.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddMember.OnIdleState.BorderRadius = 20;
            this.btnAddMember.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMember.OnIdleState.BorderThickness = 1;
            this.btnAddMember.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnAddMember.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.btnAddMember.OnIdleState.IconLeftImage = null;
            this.btnAddMember.OnIdleState.IconRightImage = null;
            this.btnAddMember.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddMember.OnPressedState.BorderRadius = 20;
            this.btnAddMember.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddMember.OnPressedState.BorderThickness = 1;
            this.btnAddMember.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddMember.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.OnPressedState.IconLeftImage = null;
            this.btnAddMember.OnPressedState.IconRightImage = null;
            this.btnAddMember.Size = new System.Drawing.Size(155, 50);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMember.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMember.TextMarginLeft = 0;
            this.btnAddMember.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddMember.UseDefaultRadiusAndThickness = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnInviteMember_Click);
            // 
            // MemberPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlMemberTabHeader);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.Name = "MemberPage";
            this.Size = new System.Drawing.Size(1058, 710);
            this.Load += new System.EventHandler(this.MemberPage_Load);
            this.pnlMemberTabHeader.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).EndInit();
            this.pnlMemberTableHeader.ResumeLayout(false);
            this.pnlMemberTableFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMemberTabHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel pnlMemberTableHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlMemberTableFilter;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuTextBox txbsearch;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMember;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvMember;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
    }
}
