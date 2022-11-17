using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Project_Management.Model;
using App_Project_Management.Views;

namespace App_Project_Management.Views
{
    public partial class ProjectCard : UserControl
    {
        ProjectDetailsModel projectCardModel = null;
        public int getProjectId()
        {
            return projectCardModel.ProjectId;
        }
        public ProjectCard()
        {
            InitializeComponent();
            projectCardModel = new ProjectDetailsModel();
        }
        public ProjectCard(int project_id)
        {
            InitializeComponent();
            projectCardModel = new ProjectDetailsModel(project_id);
        }
        public ProjectCard(DataRow row)
        {
            InitializeComponent();
            projectCardModel = new ProjectDetailsModel(row);
        }
        private void ProjectCard_Load(object sender, EventArgs e)
        {
            LoadValue();
        }

        public void LoadValue()
        {
            lbProjectName.Text = projectCardModel.ProjectName;
            lbCountMembers.Text = projectCardModel.ProjectCount_Member.ToString() + " Users";
            lbCountTasks.Text = projectCardModel.ProjectCount_Task.ToString() + " Tasks";
            lbProjectProgress.Text = projectCardModel.ProjectProgress.ToString() + "%";
            lbProjectCreateAt.Text = projectCardModel.ProjectCreateAt.ToString();
        }
        private void btnProjectDetail_Click(object sender, EventArgs e)
        {
            Form projectDetails = new frmProjectDetail(projectCardModel);
            projectDetails.ShowDialog();
        }
    }
}
