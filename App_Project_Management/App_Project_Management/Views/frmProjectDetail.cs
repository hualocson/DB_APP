using App_Project_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Project_Management.BS_Layer;
using System.Data.SqlClient;

namespace App_Project_Management.Views
{
    public partial class frmProjectDetail : Form
    {
        ProjectDetailsModel projectDetailsModel = null;

        DataTable dtTeamInProject;
        BSTeam dbTeam = new BSTeam();

        public frmProjectDetail()
        {
            InitializeComponent();
            projectDetailsModel = new ProjectDetailsModel();
        }
        public frmProjectDetail(ProjectDetailsModel pj)
        {
            InitializeComponent();
            projectDetailsModel = pj;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            frmMain.activePage = 3;
            frmMain.currentProjectID = projectDetailsModel.ProjectId;
            Close();
        }

        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            LoadTeamData();
            txbProjectName.Text = projectDetailsModel.ProjectName.ToString();
            dpDeadline.Value = projectDetailsModel.ProjectDeadline;
            dpCreateAt.Value = projectDetailsModel.ProjectCreateAt;
        }


        public void LoadTeamData()
        {
            try
            {
                dtTeamInProject = new DataTable();
                dtTeamInProject.Clear();
                dtTeamInProject = dbTeam.getTeamByProjectId(projectDetailsModel.ProjectId);
                dtgvTeams.DataSource = dtTeamInProject;
                cmbTeamList.DataSource = dbTeam.getTeamByCompanyId(projectDetailsModel.Company_id);
                cmbTeamList.ValueMember = "id";
                cmbTeamList.DisplayMember = "name";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table project Lỗi rồi!!!");
            }
        }

        private void btnAssignTeam_Click(object sender, EventArgs e)
        {
            pnlAssign.Visible = !pnlAssign.Visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = "";
            bool isSuccess = dbTeam.addTeamToProject(int.Parse(cmbTeamList.SelectedValue.ToString()), projectDetailsModel.ProjectId, DateTime.Now, ref err);
            if (!isSuccess)
            {
                MessageBox.Show("Team da co trong du an");
            }
            pnlAssign.Visible = false;
            LoadTeamData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = "";
            projectDetailsModel.ProjectName = txbProjectName.Text;
            projectDetailsModel.ProjectDeadline = dpDeadline.Value;
            projectDetailsModel.ProjectCreateAt = dpCreateAt.Value;
            bool isSuccess = projectDetailsModel.UpdateProject(ref err);
            if (!isSuccess)
            {
                MessageBox.Show(err);
            }
            else
            {
                ProjectPage.ProjectUpdatedId = projectDetailsModel.ProjectId;
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string err = "";
            bool isSuccess = projectDetailsModel.DeleteProject(ref err);
            if (!isSuccess)
            {
                MessageBox.Show(err);
            }
            else
            {
                ProjectPage.ProjectDeletedId = projectDetailsModel.ProjectId;
                Close();
            }
        }
    }
}
