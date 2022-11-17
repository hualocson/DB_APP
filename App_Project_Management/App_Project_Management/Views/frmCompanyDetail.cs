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
using System.Data.SqlClient;
using App_Project_Management.BS_Layer;
using App_Project_Management.Views;

namespace App_Project_Management.Views
{
    public partial class frmCompanyDetail : Form
    {
        public bool isAdd = false;
        CompanyDetailsModel CDModel;
        private string err = null;
        public frmCompanyDetail()
        {
            InitializeComponent();
            CDModel = new CompanyDetailsModel();
        }

        public frmCompanyDetail(string CompanyName,string Abbreviation, string Address, string Phone, int Id)
        {
            CDModel = new CompanyDetailsModel(CompanyName,Abbreviation, Address, Phone, Id);
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCompanyDetail_Load(object sender, EventArgs e)
        {
            txbCompanyName.Text = CDModel.CompanyName;
            txbAbbreviation.Text = CDModel.Abbreviation;
            txbAddress.Text = CDModel.Address;
            txbPhone.Text = CDModel.Phone;
            if (isAdd)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAddTeam.Visible = false;
            }
            else
            {
                btnAdd.Visible = false;
            }

            if(frmLogin.account.Role.Equals(Cons.ROLE.PM))
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                BSCompany bscom = new BSCompany();
                bscom.addCompany(this.txbCompanyName.Text, this.txbAbbreviation.Text, this.txbAddress.Text, this.txbPhone.Text, ref err);
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
                int r = CDModel.Id;
                BSCompany bscom = new BSCompany();
                bscom.deleteCompany(r, ref err);
                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BSCompany bscom = new BSCompany();
            bscom.updateCompany(CDModel.Id, this.txbCompanyName.Text, this.txbAbbreviation.Text, this.txbAddress.Text, this.txbPhone.Text, ref err);
            this.Close();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            frmAddTeam addteam = new frmAddTeam(CDModel.Id);
            addteam.ShowDialog();
        }
    }
}
