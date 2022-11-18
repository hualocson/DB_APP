using App_Project_Management.BS_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using App_Project_Management.Model;

namespace App_Project_Management.Views
{
    public partial class ProjectPage : UserControl
    {
        DataTable dtProject;
        BSProject dbProject = new BSProject();
        List<ProjectCard> projectCards = new List<ProjectCard>();
        public static int ProjectUpdatedId = -1;
        public static int ProjectInsertedId = -1;
        public static int ProjectDeletedId = -1;
        public ProjectPage()
        {
            InitializeComponent();
            VScrollBar.Value = 0;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Form addProject = new frmAddProject();
            addProject.ShowDialog();
        }
        public void LoadData()
        {
            try
            {
                dtProject = new DataTable();
                dtProject.Clear();
                dtProject = dbProject.getAllProject();
                projectCards.Clear();
                foreach (DataRow row in dtProject.Rows)
                {
                    ProjectCard card = new ProjectCard(row);
                    card.Dock = DockStyle.Fill;
                    projectCards.Add(card);
                }
                scrollTo(page_index);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Project Lỗi rồi!!!");
            }
            if (frmLogin.account.Role.Equals(Cons.ROLE.TL) || frmLogin.account.Role.Equals(Cons.ROLE.TM))
            {
                this.btnAddProject.Enabled = false;
            }
        }

        public void LoadUpdateData()
        {
            if (ProjectUpdatedId != -1)
            {
                foreach (ProjectCard card in projectCards)
                {
                    if (card.getProjectId() == ProjectUpdatedId)
                    {
                        card.LoadValue();
                    }
                }
                ProjectUpdatedId = -1;
            }
            if (ProjectInsertedId != -1)
            {
                ProjectCard card = new ProjectCard(ProjectInsertedId);
                card.Dock = DockStyle.Fill;
                projectCards.Add(card);
                if(isInLastPage())
                    tbpnlProject.Controls.Add(card);
                ProjectInsertedId = -1;
            }
            if (ProjectDeletedId != -1)
            {
                int index = 0;
                foreach (ProjectCard card in projectCards)
                {

                    if (card.getProjectId() == ProjectDeletedId)
                    {
                        index = projectCards.IndexOf(card);
                        tbpnlProject.Controls.Remove(projectCards[index]);
                    }
                }
                projectCards.RemoveAt(index);
                ProjectDeletedId = -1;
            }
        }
        private void ProjectPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool isInLastPage()
        {
            int max_page = projectCards.Count / 6;
            if (projectCards.Count % 6 != 0)
                max_page++;
            return page_index >= max_page;
        }
        void scrollTo(int index)
        {
            VScrollBar.Value = index;
        }
        void scrollNext()
        {
            if (!isInLastPage())
                page_index++;
            scrollTo(page_index);
        }

        void scrollPrevious()
        {
            if (page_index > 1)
                page_index--;
            scrollTo(page_index);
        }

        private void VScrollBar_ValueChanged(object sender, EventArgs e)
        {
            tbpnlProject.SuspendLayout();
            tbpnlProject.Controls.Clear();
            tbpnlProject.Controls.AddRange(projectCards.Skip((VScrollBar.Value - 1) * 6).Take(6).ToArray());
            tbpnlProject.ResumeLayout();
        }

        int page_index = 1;
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            scrollNext();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            scrollPrevious();
        }

        private void txbsearch_TextChange(object sender, EventArgs e)
        {
        }
    }
}
