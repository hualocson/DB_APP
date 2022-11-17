using ProjectManagerApp.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.BS_Layer
{
    internal class BSTeam
    {
        DBMain db = null;
        public BSTeam()
        {
            db = new DBMain();
        }
        public DataTable getTeamByProjectId(int id)
        {
            string sqlString = $"exec getTeamByProjectId {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getTeamByCompanyId(int id)
        {
            string sqlString = $"exec getTeamByCompanyId {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public bool addTeamToProject(int team_id, int project_id, DateTime created_at, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC addTeamToProject {team_id}, {project_id}, '{created_at}'", CommandType.Text, ref err);
        }
        public bool addTeam(string name, string abbreviation,int team_lead, int company_id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC addTeam '{name}','{abbreviation}',{team_lead},{company_id}", CommandType.Text, ref err);
        }
        public DataTable getTeamLeadInCompany(int id)
        {
            string sqlString = $"exec getTeamLeadInCompany {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];

        }
    }
}
