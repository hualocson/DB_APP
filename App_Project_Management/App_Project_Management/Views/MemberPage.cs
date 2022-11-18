using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using App_Project_Management.BS_Layer;
using App_Project_Management.Model;

namespace App_Project_Management.Views
{
    public partial class MemberPage : UserControl
    {
        DataTable dtMember;
        BSMember dbMem = new BSMember();
        public MemberPage()
        {
            InitializeComponent();
        }

        private void btnInviteMember_Click(object sender, EventArgs e)
        {
            frmMemberDetail member = new frmMemberDetail();
            member.isAdd = true;
            member.ShowDialog();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            Form inviteMember = new frmInviteMember();
            inviteMember.ShowDialog();
        }
        public void LoadData()
        {
            switch (frmLogin.account.Role)
            {
                case Cons.ROLE.SA:
                    try
                    {
                        dtMember = new DataTable();
                        dtMember.Clear();
                        dtMember = dbMem.getAllMember();
                        // Đưa dữ liệu lên DataGridView 
                        dtgvMember.DataSource = dtMember;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                    }
                    break;
                case Cons.ROLE.PM:
                    try
                    {
                        dtMember = new DataTable();
                        dtMember.Clear();
                        dtMember = dbMem.getAllMemberByCompanyId(frmLogin.account.Company_id);
                        // Đưa dữ liệu lên DataGridView 
                        dtgvMember.DataSource = dtMember;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                    }
                    break;
                case Cons.ROLE.TL:
                    try
                    {
                        dtMember = new DataTable();
                        dtMember.Clear();
                        dtMember = dbMem.getAllMemberByTeamId(frmLogin.account.Team_id);
                        // Đưa dữ liệu lên DataGridView 
                        dtgvMember.DataSource = dtMember;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                    }
                    break;
                case Cons.ROLE.TM:
                    break;
            }
        }

        public void LoadMemberWithWord()
        {
            if (!frmLogin.account.Role.Equals(Cons.ROLE.TL))
            {
                try
                {
                    dtgvMember.DataSource = dbMem.searchMemberInCompanyByName((int)frmLogin.account.Company_id, this.txbsearch.Text);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                }
            }
            else
            {
                try
                {
                    dtgvMember.DataSource = dbMem.searchMemberInTeamByName((int)frmLogin.account.Team_id, this.txbsearch.Text);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table Company Lỗi rồi!!!");
                }
            }
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvMember.CurrentCell.RowIndex;
            string name = dtgvMember.Rows[r].Cells[1].Value.ToString();
            string username = dtgvMember.Rows[r].Cells[7].Value.ToString();
            string password = dtgvMember.Rows[r].Cells[8].Value.ToString();
            int id = Int32.Parse(dtgvMember.Rows[r].Cells[0].Value.ToString());
            bool gender = bool.Parse(dtgvMember.Rows[r].Cells[2].Value.ToString());
            frmMemberDetail member_details = new frmMemberDetail(name, username, password, gender, id);
            member_details.isMale = gender;
            member_details.ShowDialog();
        }

        private void txbsearch_TextChange(object sender, EventArgs e)
        {
            LoadMemberWithWord();
        }
    }
}
