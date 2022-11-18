using ProjectManagerApp.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.BS_Layer
{
    internal class BSTask
    {
        DBMain db = null;
        public BSTask()
        {
            db = new DBMain();
        }

        public DataTable getTaskByStatusAndProjectId(int status_id, int project_id)
        {
            string sqlString = $"EXEC getTaskByStatusAndProjectId {status_id}, {project_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getTaskByStatusAndProjectAndTeamId(int status_id, int project_id, int team_id)
        {
            string sqlString = $"EXEC getTaskByStatusAndProjectAndTeamId {status_id}, {project_id}, {team_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public bool addTask(string name, string desc, DateTime duedate, int project_id, int assignee_id, int create_user, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC addTask '{name}', {desc}, '{duedate}', {project_id}, {assignee_id}, {create_user}", CommandType.Text, ref err);
        }

        public DataTable getTaskByStatusAndProjectAndMemberId(int status_id, int project_id, int member_id)
        {
            string sqlString = $"EXEC getTaskByStatusAndProjectAndMemberId {status_id}, {project_id}, {member_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
    }
}
