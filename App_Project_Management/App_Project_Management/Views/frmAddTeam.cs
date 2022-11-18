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
    public partial class frmAddTeam : Form
    {
        TeamDetailsModel TDModel;
        DataTable dtTeamListInCompany;
        private string err = null;
        BSTeam dbTeam = new BSTeam();
        public frmAddTeam()
        {
            InitializeComponent();
            TDModel = new TeamDetailsModel();
        }
        public frmAddTeam(int Company_id)
        {
            InitializeComponent();
            TDModel = new TeamDetailsModel(Company_id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                BSTeam bsteam = new BSTeam();
                bsteam.addTeam(this.txbname.Text, this.txbabbreviation.Text, TDModel.Company_id, ref err);
                // Load lại dữ liệu trên DataGridView
                // Thông báo 
                this.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void frmAddTeam_Load(object sender, EventArgs e)
        {
            txbname.Text = TDModel.Name;
            txbabbreviation.Text = TDModel.Abbreviation;
        }
    }
}
