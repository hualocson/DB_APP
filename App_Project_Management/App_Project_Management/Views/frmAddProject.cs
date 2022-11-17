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
using App_Project_Management.BS_Layer;

namespace App_Project_Management.Views
{
    public partial class frmAddProject : Form
    {
        ProjectDetailsModel projectModel = null;
        public frmAddProject()
        {
            InitializeComponent();
            projectModel = new ProjectDetailsModel();
        }
        public void LoadCompanyData()
        {
            BSCompany company = new BSCompany();
            cmbCompany.DataSource = company.getAllCompany();
            cmbCompany.ValueMember = "id";
            cmbCompany.DisplayMember = "name";
            cmbCompany.Text = "Select Company";
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            LoadCompanyData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            projectModel.ProjectName = txbProjectName.Text;
            projectModel.ProjectDeadline = dpDeadline.Value;
            projectModel.ProjectKey = txbKey.Text;

            if (cmbCompany.SelectedValue == null)
                projectModel.Company_id = 1;
            else
                projectModel.Company_id = int.Parse(cmbCompany.SelectedValue.ToString());
            string err = "";
            ProjectPage.ProjectInsertedId = projectModel.AddProject(ref err);
            Close();
        }
    }
}