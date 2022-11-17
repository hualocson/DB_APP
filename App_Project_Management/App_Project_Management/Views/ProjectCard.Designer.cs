namespace App_Project_Management.Views
{
    partial class ProjectCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCard));
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.pnlMemberProjectList = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProjectProgress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCountTasks = new System.Windows.Forms.Label();
            this.btnProjectDetail = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlTaskQty = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lbCountMembers = new System.Windows.Forms.Label();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProjectCreateAt = new System.Windows.Forms.Label();
            this.roundedProjectCardControl = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlProgress.SuspendLayout();
            this.pnlMemberProjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTaskQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgress.Controls.Add(this.pnlMemberProjectList);
            this.pnlProgress.Controls.Add(this.lbProjectProgress);
            this.pnlProgress.Controls.Add(this.label4);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 187);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Padding = new System.Windows.Forms.Padding(10);
            this.pnlProgress.Size = new System.Drawing.Size(340, 78);
            this.pnlProgress.TabIndex = 13;
            // 
            // pnlMemberProjectList
            // 
            this.pnlMemberProjectList.BackColor = System.Drawing.Color.Transparent;
            this.pnlMemberProjectList.Controls.Add(this.pictureBox4);
            this.pnlMemberProjectList.Controls.Add(this.label7);
            this.pnlMemberProjectList.Controls.Add(this.pictureBox3);
            this.pnlMemberProjectList.Controls.Add(this.pictureBox2);
            this.pnlMemberProjectList.Controls.Add(this.pictureBox1);
            this.pnlMemberProjectList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMemberProjectList.Location = new System.Drawing.Point(10, 10);
            this.pnlMemberProjectList.Name = "pnlMemberProjectList";
            this.pnlMemberProjectList.Size = new System.Drawing.Size(201, 58);
            this.pnlMemberProjectList.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(147, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Users";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(101, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lbProjectProgress
            // 
            this.lbProjectProgress.AutoSize = true;
            this.lbProjectProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectProgress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectProgress.Location = new System.Drawing.Point(260, 47);
            this.lbProjectProgress.Name = "lbProjectProgress";
            this.lbProjectProgress.Size = new System.Drawing.Size(40, 18);
            this.lbProjectProgress.TabIndex = 6;
            this.lbProjectProgress.Text = "30%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Progress";
            // 
            // lbCountTasks
            // 
            this.lbCountTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCountTasks.Location = new System.Drawing.Point(5, 5);
            this.lbCountTasks.Name = "lbCountTasks";
            this.lbCountTasks.Size = new System.Drawing.Size(55, 47);
            this.lbCountTasks.TabIndex = 0;
            this.lbCountTasks.Text = "14 Tasks";
            this.lbCountTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProjectDetail
            // 
            this.btnProjectDetail.ActiveImage = null;
            this.btnProjectDetail.AllowAnimations = true;
            this.btnProjectDetail.AllowBuffering = false;
            this.btnProjectDetail.AllowToggling = false;
            this.btnProjectDetail.AllowZooming = true;
            this.btnProjectDetail.AllowZoomingOnFocus = false;
            this.btnProjectDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnProjectDetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProjectDetail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnProjectDetail.ErrorImage")));
            this.btnProjectDetail.FadeWhenInactive = false;
            this.btnProjectDetail.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnProjectDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectDetail.Image")));
            this.btnProjectDetail.ImageActive = null;
            this.btnProjectDetail.ImageLocation = null;
            this.btnProjectDetail.ImageMargin = 0;
            this.btnProjectDetail.ImageSize = new System.Drawing.Size(27, 27);
            this.btnProjectDetail.ImageZoomSize = new System.Drawing.Size(28, 28);
            this.btnProjectDetail.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnProjectDetail.InitialImage")));
            this.btnProjectDetail.Location = new System.Drawing.Point(298, 12);
            this.btnProjectDetail.Name = "btnProjectDetail";
            this.btnProjectDetail.Rotation = 0;
            this.btnProjectDetail.ShowActiveImage = true;
            this.btnProjectDetail.ShowCursorChanges = true;
            this.btnProjectDetail.ShowImageBorders = true;
            this.btnProjectDetail.ShowSizeMarkers = false;
            this.btnProjectDetail.Size = new System.Drawing.Size(28, 28);
            this.btnProjectDetail.TabIndex = 11;
            this.btnProjectDetail.ToolTipText = "";
            this.btnProjectDetail.WaitOnLoad = false;
            this.btnProjectDetail.Zoom = 0;
            this.btnProjectDetail.ZoomSpeed = 10;
            this.btnProjectDetail.Click += new System.EventHandler(this.btnProjectDetail_Click);
            // 
            // pnlTaskQty
            // 
            this.pnlTaskQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.pnlTaskQty.Controls.Add(this.bunifuSeparator1);
            this.pnlTaskQty.Controls.Add(this.lbCountMembers);
            this.pnlTaskQty.Controls.Add(this.lbCountTasks);
            this.pnlTaskQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlTaskQty.Location = new System.Drawing.Point(186, 114);
            this.pnlTaskQty.Name = "pnlTaskQty";
            this.pnlTaskQty.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTaskQty.Size = new System.Drawing.Size(140, 57);
            this.pnlTaskQty.TabIndex = 12;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(60, 5);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(15, 47);
            this.bunifuSeparator1.TabIndex = 2;
            // 
            // lbCountMembers
            // 
            this.lbCountMembers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCountMembers.Location = new System.Drawing.Point(75, 5);
            this.lbCountMembers.Name = "lbCountMembers";
            this.lbCountMembers.Size = new System.Drawing.Size(60, 47);
            this.lbCountMembers.TabIndex = 1;
            this.lbCountMembers.Text = "4 Teams";
            this.lbCountMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectName.Location = new System.Drawing.Point(12, 12);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(133, 22);
            this.lbProjectName.TabIndex = 10;
            this.lbProjectName.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Create date";
            // 
            // lbProjectCreateAt
            // 
            this.lbProjectCreateAt.AutoSize = true;
            this.lbProjectCreateAt.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectCreateAt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectCreateAt.Location = new System.Drawing.Point(37, 85);
            this.lbProjectCreateAt.Name = "lbProjectCreateAt";
            this.lbProjectCreateAt.Size = new System.Drawing.Size(82, 16);
            this.lbProjectCreateAt.TabIndex = 15;
            this.lbProjectCreateAt.Text = "12 Sep 2021";
            // 
            // roundedProjectCardControl
            // 
            this.roundedProjectCardControl.ElipseRadius = 30;
            this.roundedProjectCardControl.TargetControl = this;
            // 
            // ProjectCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.btnProjectDetail);
            this.Controls.Add(this.pnlTaskQty);
            this.Controls.Add(this.lbProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProjectCreateAt);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(91)))), ((int)(((byte)(110)))));
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.Name = "ProjectCard";
            this.Size = new System.Drawing.Size(340, 265);
            this.Load += new System.EventHandler(this.ProjectCard_Load);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.pnlMemberProjectList.ResumeLayout(false);
            this.pnlMemberProjectList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTaskQty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Panel pnlMemberProjectList;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbProjectProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCountTasks;
        private Bunifu.UI.WinForms.BunifuImageButton btnProjectDetail;
        private System.Windows.Forms.Panel pnlTaskQty;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lbCountMembers;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProjectCreateAt;
        private Bunifu.Framework.UI.BunifuElipse roundedProjectCardControl;
    }
}
