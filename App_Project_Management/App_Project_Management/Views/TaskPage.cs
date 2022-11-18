using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Project_Management.BS_Layer;
using App_Project_Management.Model;

namespace App_Project_Management.Views
{
    public partial class TaskPage : UserControl
    {
        TaskModel taskModel = null;
        int currentProjectID;
        public TaskPage()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            currentProjectID = frmMain.currentProjectID;
            taskModel = new TaskModel(currentProjectID);

            switch (frmLogin.account.Role)
            {
                case Cons.ROLE.SA:
                case Cons.ROLE.PM:
                    dtgvTodo.DataSource = taskModel.getTaskByStatusAndProjectId(Cons.TASK_STATUS.TODO);
                    dtgvInProgress.DataSource = taskModel.getTaskByStatusAndProjectId(Cons.TASK_STATUS.INPROGRESS);
                    dtgvPending.DataSource = taskModel.getTaskByStatusAndProjectId(Cons.TASK_STATUS.PENDING);
                    dtgvDone.DataSource = taskModel.getTaskByStatusAndProjectId(Cons.TASK_STATUS.DONE);
                    break;
                case Cons.ROLE.TL:
                    dtgvTodo.DataSource = taskModel.getTaskForTeamLead(Cons.TASK_STATUS.TODO, frmLogin.account.Team_id);
                    dtgvInProgress.DataSource = taskModel.getTaskForTeamLead(Cons.TASK_STATUS.INPROGRESS, frmLogin.account.Team_id);
                    dtgvPending.DataSource = taskModel.getTaskForTeamLead(Cons.TASK_STATUS.PENDING, frmLogin.account.Team_id);
                    dtgvDone.DataSource = taskModel.getTaskForTeamLead(Cons.TASK_STATUS.DONE, frmLogin.account.Team_id);
                    break;
                case Cons.ROLE.TM:
                    btnAddTodoTask.Enabled = false;
                    dtgvTodo.DataSource = taskModel.getTaskForMember(Cons.TASK_STATUS.TODO, frmLogin.account.Id);
                    dtgvInProgress.DataSource = taskModel.getTaskForMember(Cons.TASK_STATUS.INPROGRESS, frmLogin.account.Id);
                    dtgvPending.DataSource = taskModel.getTaskForMember(Cons.TASK_STATUS.PENDING, frmLogin.account.Id);
                    dtgvDone.DataSource = taskModel.getTaskForMember(Cons.TASK_STATUS.DONE, frmLogin.account.Id);
                    break;
            }
            
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnAddTodoTask_Click(object sender, EventArgs e)
        {
            frmTaskDetails taskDetails = new frmTaskDetails();
            taskDetails.isAdd = true;
            taskDetails.project_id = currentProjectID;
            taskDetails.ShowDialog();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gv = sender as DataGridView;
            if (gv.CurrentCell != null)
            {
                frmTaskDetails taskDetails = new frmTaskDetails(gv.Rows[gv.CurrentCell.RowIndex]);
                taskDetails.isAdd = false;
                taskDetails.project_id = currentProjectID;
                taskDetails.ShowDialog();
            }
        }
    }
}
