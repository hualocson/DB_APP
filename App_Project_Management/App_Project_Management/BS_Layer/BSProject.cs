using ProjectManagerApp.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.BS_Layer
{
    internal class BSProject
    {
        DBMain db = null;
        public BSProject()
        {
            db = new DBMain();
        }

        public DataTable getAllProject()
        {
            string sqlString = "EXEC getAllProject";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getProjectById(int id)
        {
            string sqlString = $"EXEC getProjectById {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }

        public DataTable searchProjectByName(string name)
        {
            string sqlString = $"SELECT * FROM dbo.searchProjectByName('{name}')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public int addProject(string name, int progress, DateTime deadline, DateTime created_at,int company_id, string key, ref string err)
        {
            return int.Parse(db.ExcuteQueryScalar($"EXEC addProject '{name}',{progress},'{deadline}','{created_at}', {company_id},'{key}'", CommandType.Text, ref err));
        }
        public bool updateProject(int id, string name, int progress, DateTime deadline, DateTime created_at, int company_id,  string key, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC updateProject {id},'{name}', {progress},'{deadline}','{created_at}', {company_id}, '{key}'", CommandType.Text, ref err);
        }
        public bool deleteProject(int id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC deleteProject {id}", CommandType.Text, ref err);
        }

        public int countMemberInProject(int id, ref string err)
        {
            return int.Parse(db.ExcuteQueryScalar($"select dbo.countMemberInProject({id})", CommandType.Text, ref err));
        }
        public int countTaskInProject(int id, ref string err)
        {
            return int.Parse(db.ExcuteQueryScalar($"select dbo.countTaskInProject({id})", CommandType.Text, ref err));
        }
    }
}
