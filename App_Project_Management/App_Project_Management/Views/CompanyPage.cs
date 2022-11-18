using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using App_Project_Management.BS_Layer;
using App_Project_Management.Model;
namespace App_Project_Management.Views
{
    public partial class CompanyPage : UserControl
    {
        DataTable dtCompany;
        BSCompany dbCom = new BSCompany();
        public CompanyPage()
        {
            InitializeComponent();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            frmCompanyDetail company = new frmCompanyDetail();
            company.isAdd = true;
            company.ShowDialog();
        }
        public void LoadData()
        {
            if(frmLogin.account.Role.Equals(Cons.ROLE.SA))
            {
                try
                {
                    dtCompany = new DataTable();
                    dtCompany.Clear();
                    dtCompany = dbCom.getAllCompany();
                    // Đưa dữ liệu lên DataGridView 
                    dtgvCompany.DataSource = dtCompany;

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                }
            }
            else if (frmLogin.account.Role.Equals(Cons.ROLE.PM))
            {
                try
                {
                    dtCompany = new DataTable();
                    dtCompany.Clear();
                    dtCompany = dbCom.getCompanyById(frmLogin.account.Company_id);
                    // Đưa dữ liệu lên DataGridView 
                    dtgvCompany.DataSource = dtCompany;
                    btnAddCompany.Enabled = false;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                }
            }
        }
        private void LoadDataWithWord()
        {
            try
            {
                dtgvCompany.DataSource = dbCom.searchCompanyByName(this.txbseach.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
            }
        }
        private void CompanyPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvCompany.CurrentCell.RowIndex;
            string name = dtgvCompany.Rows[r].Cells[1].Value.ToString();
            string abbreviation = dtgvCompany.Rows[r].Cells[2].Value.ToString();
            string address = dtgvCompany.Rows[r].Cells[3].Value.ToString();
            string phone = dtgvCompany.Rows[r].Cells[4].Value.ToString();
            int id = Int32.Parse( dtgvCompany.Rows[r].Cells[0].Value.ToString());
            Form company_details = new frmCompanyDetail(name,abbreviation, address, phone, id) ;
            company_details.ShowDialog();
        }

        private void txbseach_TextChange(object sender, EventArgs e)
        {
            if (frmLogin.account.Role.Equals(Cons.ROLE.SA))
            {
                LoadDataWithWord();
            }
        }

        private void txbseach_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
