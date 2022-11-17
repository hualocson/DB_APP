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
    public partial class frmMemberDetail : Form
    {
        public bool isAdd = false;
        public bool isMale;
        MemberDetailsModel MBModel;
        private string err = null;
        public frmMemberDetail()
        {
            InitializeComponent();
            MBModel = new MemberDetailsModel();
        }

        public frmMemberDetail(string Name, string Username, string Pasword,bool Gender, int Id)
        {
            MBModel = new MemberDetailsModel(Name, Username, Pasword, Gender, Id);
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtName.Text = MBModel.Name;
            txtEmail.Text = MBModel.Username;
            txtpassword.Text = MBModel.Password;
            isMale = MBModel.Gender;
            if (isAdd)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                btnAdd.Visible = false;
            }
            if (isMale)
            {
                gendermalebtn.Checked = true;
            }
            else
            {
                genderfemalebtn.Checked = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                BSMember bsmem = new BSMember();
                if(gendermalebtn.Checked)
                {
                    isMale = true;
                }
                else if (genderfemalebtn.Checked)
                {
                    isMale = false;
                }
                bsmem.addMemberWithNameAndAccount(this.txtName.Text,this.isMale, this.txtEmail.Text, this.txtpassword.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                // Thông báo 
                this.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = MBModel.Id;
                BSMember bsmem = new BSMember();
                bsmem.deleteMember(r, ref err);
                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BSMember bsmem = new BSMember();
            if (gendermalebtn.Checked)
            {
                isMale = true;
            }
            else if (genderfemalebtn.Checked)
            {
                isMale = false;
            }
            bsmem.uppdateMemberWithNameAndAccount(MBModel.Id, this.txtName.Text,isMale, this.txtEmail.Text, this.txtpassword.Text, ref err);
            this.Close();
        }

        private void gendermalebtn_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            isMale = true;
        }

        private void genderfemalebtn_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            isMale = false;
        }
    }
}
