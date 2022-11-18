using App_Project_Management.BS_Layer;
using App_Project_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Project_Management.Views
{
    public partial class frmTaskDetails : Form
    {
        public bool isAdd;
        public int project_id;
        public frmTaskDetails()
        {
            InitializeComponent();
            cirProgress.Value = 0;
            cirProgress.ValueByTransition = cirProgress.Value;
        }

        public frmTaskDetails(DataGridViewRow row)
        {
            InitializeComponent();
            txbTaskName.Text = row.Cells[1].Value.ToString();
            txbTaskDesc.Text = row.Cells[2].Value.ToString();
            dpDeadline.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            cirProgress.Value = int.Parse(row.Cells[5].Value.ToString());
            cirProgress.ValueByTransition = cirProgress.Value;

            BSMember blMember = new BSMember();
            string err = "";
            cmbAssigneeMember.Text = blMember.getMemberNameById(int.Parse(row.Cells[8].Value.ToString()), ref err);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadAssignee()
        {
            BSMember blMember = new BSMember();

            switch (frmLogin.account.Role)
            {
                case Cons.ROLE.SA:
                case Cons.ROLE.PM:
                    cmbAssigneeMember.DataSource = blMember.getMemberByProjectId(this.project_id);
                    cmbAssigneeMember.ValueMember = "id";
                    cmbAssigneeMember.DisplayMember = "name";
                    cmbAssigneeMember.Text = "Select Member";
                    break;
                case Cons.ROLE.TL:
                    cmbAssigneeMember.DataSource = blMember.getAllMemberByTeamId(frmLogin.account.Team_id);
                    cmbAssigneeMember.ValueMember = "id";
                    cmbAssigneeMember.DisplayMember = "name";
                    cmbAssigneeMember.Text = "Select Member";
                    break;
                case Cons.ROLE.TM:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TaskModel taskModel = new TaskModel(this.project_id);
                string err = "";
                taskModel.addTask(txbTaskName.Text, txbTaskDesc.Text, dpDeadline.Value, int.Parse(cmbAssigneeMember.SelectedValue.ToString()), frmLogin.account.Id, ref err);
                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void frmTaskDetails_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                loadAssignee();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
