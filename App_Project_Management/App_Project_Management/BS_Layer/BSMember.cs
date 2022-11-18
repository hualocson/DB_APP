using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagerApp.DB_Layer;
using System.Data;

namespace App_Project_Management.BS_Layer
{
    internal class BSMember
    {
        DBMain db = null;
        public BSMember()
        {
            db = new DBMain();
        }

        public int getUserByUsername(string username, string password, ref string err)
        {
            string sqlString = $"SELECT dbo.getMemberByUsername('{username}','{password}')";
            return Int32.Parse(db.ExcuteQueryScalar(sqlString, CommandType.Text, ref err));
        }

        public string getMemberNameById(int id, ref string err)
        {
            string sqlString = $"select dbo.getMemberNameById({id})";
            return db.ExcuteQueryScalar(sqlString, CommandType.Text, ref err);
        }

        public DataTable getMemberById(int id)
        {
            string sqlString = $"EXEC getMemberById {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getAllMember()
        {
            string sqlString = "EXEC getAllMember";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable searchMemberInCompanyByName(int id, string name)
        {
            string sqlString = $"SELECT * FROM dbo.searchMemberInCompanyByName({id},'{name}')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable searchMemberInTeamByName(int id, string name)
        {
            string sqlString = $"SELECT * FROM dbo.searchMemberInTeamByName({id},'{name}')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getAllMemberByCompanyId(int company_id)
        {
            string sqlString = $"EXEC getAllMemberByCompanyId {company_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public DataTable getAllMemberByTeamId(int team_id)
        {
            string sqlString = $"EXEC getAllMemberByTeamId {team_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }

        public DataTable getMemberByProjectId(int project_id)
        {
            string sqlString = $"EXEC getMemberByProjectId {project_id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }
        public bool addMember(string name, bool gender, int role, int team_id, string username, string password, int company_id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC addMember '{name}',{gender},{role},{team_id},'{username}','{password}',{company_id}", CommandType.Text, ref err);
        }

        public bool addMemberWithNameAndAccount(string name, bool gender, string username, string password, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC addMember '{name}',{gender},null,null,'{username}','{password}',null", CommandType.Text, ref err);
        }

        public bool updateMember(int id, string name, bool gender, int role, int team_id, string username, string password, int company_id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC updateMember {id},'{name}',{gender},{role},{team_id},'{username}','{password}',{company_id}", CommandType.Text, ref err);
        }
        public bool updateMember(int id, string name, bool gender, int role, string username, string password, int company_id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC updateMember {id},'{name}',{gender},{role},null,'{username}','{password}',{company_id}", CommandType.Text, ref err);
        }
        public bool uppdateMemberWithNameAndAccount(int id, string name, bool gender, string username, string password, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC updateMemberNoneTeam {id},'{name}',{gender},'{username}','{password}'", CommandType.Text, ref err);
        }
        public bool deleteMember(int id, ref string err)
        {
            return db.MyExecuteNonQuery($"EXEC deleteMember {id}", CommandType.Text, ref err);
        }
        public int checkExistUserAndTeamCompanyRoleIsNull(string username, ref string err)
        {
            string sqlString = $"SELECT dbo.checkExistUserAndTeamCompanyRoleIsNull('{username}')";
            return Int32.Parse(db.ExcuteQueryScalar(sqlString, CommandType.Text, ref err));
        }
    }
}
