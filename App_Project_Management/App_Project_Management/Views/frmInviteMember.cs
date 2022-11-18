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
            if (frmLogin.account.Role.Equals(Cons.ROLE.PM) || frmLogin.account.Role.Equals(Cons.ROLE.TL))
            {
                try
                {
                    cmbCompany.DataSource = dbCom.getCompanyById((int)frmLogin.account.Company_id);
                    cmbCompany.ValueMember = "id";
                    cmbCompany.DisplayMember = "name";
                    cmbCompany.Text = "Select company";
                    LoadTeamInCompany();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table company Lỗi rồi!!!");
                }
            }
            else
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
            
        }

        public void LoadTeamInCompany()
        {
            if (frmLogin.account.Role.Equals(Cons.ROLE.TL))
            {
                try
                {
                    cmbTeam.DataSource = dbTeam.getTeamById((int)frmLogin.account.Team_id);
                    cmbTeam.ValueMember = "id";
                    cmbTeam.DisplayMember = "name";
                    cmbTeam.Text = "Select team";
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table team Lỗi rồi!!!");
                }
            }
            else
            {
                try
                {
                    if(cmbRole.Text == "Team Lead")
                    {
                        cmbTeam.DataSource = dbTeam.getTeamNoneTeamLeadByCompanyId(int.Parse(cmbCompany.SelectedValue.ToString()));
                        cmbTeam.ValueMember = "id";
                        cmbTeam.DisplayMember = "name";
                        cmbTeam.Text = "Select team";
                    }
                    else if(cmbRole.Text == "Team Member")
                    { 
                        cmbTeam.DataSource = dbTeam.getTeamByCompanyId(int.Parse(cmbCompany.SelectedValue.ToString()));
                        cmbTeam.ValueMember = "id";
                        cmbTeam.DisplayMember = "name";
                        cmbTeam.Text = "Select team";
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table team Lỗi rồi!!!");
                }
            }
            
        }

        public void LoadRole()
        {
            try
            {
                cmbRole.Text = "";
                cmbRole.DataSource = dbRole.getdownRole((int)frmLogin.account.Role);
                cmbRole.ValueMember = "id";
                cmbRole.DisplayMember = "name";
                cmbRole.Text = "Select Role";
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
                if (cmbRole.Text == "Project Manager")
                {
                    dbmem.updateMember(r, MDModel.Name, MDModel.Gender, int.Parse(cmbRole.SelectedValue.ToString()), MDModel.Username, MDModel.Password, int.Parse(cmbCompany.SelectedValue.ToString()), ref err);
                }
                else
                {
                    dbmem.updateMember(r, MDModel.Name, MDModel.Gender, int.Parse(cmbRole.SelectedValue.ToString()), int.Parse(cmbTeam.SelectedValue.ToString()), MDModel.Username, MDModel.Password, int.Parse(cmbCompany.SelectedValue.ToString()), ref err);
                }
            }
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.Text == "Project Manager")
            {
                cmbTeam.Visible = false;
            }
            else
            {
                cmbTeam.Visible = true;
            }
        }
    }
}
