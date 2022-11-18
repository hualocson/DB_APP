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
using System.Data.SqlClient;

namespace App_Project_Management.Views
{
    public partial class frmInviteMember : Form
    {
        private string err = null;
        BSCompany dbCom = new BSCompany();
        BSTeam dbTeam = new BSTeam();
        BSRole dbRole = new BSRole();
        BSMember dbmem = new BSMember();
        MemberDetailsModel MDModel;
        public frmInviteMember()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadCompanyDetails()
        {
            try
            {
                cmbCompany.DataSource = dbCom.getAllCompany();
                cmbCompany.ValueMember = "id";
                cmbCompany.DisplayMember = "name";
                cmbCompany.Text = "Select company";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table company Lỗi rồi!!!");
            }
        }

        public void LoadTeamInCompany()
        {
            try
            {
                cmbTeam.Text = "";
                cmbTeam.DataSource = dbTeam.getTeamByCompanyId(int.Parse(cmbCompany.SelectedValue.ToString()));
                cmbTeam.ValueMember = "id";
                cmbTeam.DisplayMember = "name";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table team Lỗi rồi!!!");
            }
        }

        public void LoadRole()
        {
            try
            {
                cmbRole.Text = "";
                cmbRole.DataSource = dbRole.getRole();
                cmbRole.ValueMember = "id";
                cmbRole.DisplayMember = "name";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table role Lỗi rồi!!!");
            }
        }

        private void frmInviteMember_Load(object sender, EventArgs e)
        {
            LoadCompanyDetails();
            LoadRole();
        }

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTeamInCompany();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            int r = dbmem.checkExistUserAndTeamCompanyRoleIsNull(txbUserName.Text, ref err);
            if(r == 0)
            {
                MessageBox.Show("Check lại thông tin member cần invite");
            }
            else
            {
                MDModel = new MemberDetailsModel(r);
                dbmem.updateMember(r,MDModel.Name,MDModel.Gender,int.Parse(cmbRole.SelectedValue.ToString()), int.Parse(cmbTeam.SelectedValue.ToString()),MDModel.Username,MDModel.Password, int.Parse(cmbCompany.SelectedValue.ToString()),ref err);
            }
            this.Close();
        }
    }
}
