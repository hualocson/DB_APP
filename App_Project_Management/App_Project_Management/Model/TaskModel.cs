using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.Model
{
    public class TaskModel
    {
        private int project_id;

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
        BS_Layer.BSTask blTask = null;
        public TaskModel(int projectId)
        {
            blTask = new BS_Layer.BSTask();
            project_id = projectId;
        }
        public DataTable getTaskByStatusAndProjectId(Cons.TASK_STATUS status_id)
        {
            return blTask.getTaskByStatusAndProjectId((int)status_id, Project_id);
        }
        public DataTable getTaskForTeamLead(Cons.TASK_STATUS status_id, int team_id)
        {
            return blTask.getTaskByStatusAndProjectAndTeamId((int)status_id, Project_id, team_id);
        }

        public DataTable getTaskForMember(Cons.TASK_STATUS status_id, int member_id)
        { 
            return blTask.getTaskByStatusAndProjectAndMemberId((int)status_id, Project_id, member_id);

        }
        public bool addTask(string name, string desc, DateTime duedate, int assignee_id, int create_user, ref string err)
        {
            return blTask.addTask(name, desc, duedate, this.project_id, assignee_id, create_user, ref err);
        }
    }
}
