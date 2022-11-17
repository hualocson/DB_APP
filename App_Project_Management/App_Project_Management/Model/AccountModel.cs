using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using App_Project_Management.BS_Layer;

namespace App_Project_Management.Model
{
    public class AccountModel
    {
        #region Constructor
        public AccountModel()
        {
            member = new BSMember();
            id = 0;
            name = string.Empty;
            role = Cons.ROLE.TM;
            team_id = 0;
            username = string.Empty;
            password = string.Empty;
            company_id = 0;
        }
        #endregion

        #region Method
        private void setValueForInstance(int id)
        {
            member = new BSMember();
            DataRow memberRecord = member.getMemberById(id).Rows[0];
            name = memberRecord["name"].ToString();
            username = memberRecord["username"].ToString();
            password = memberRecord["password"].ToString();
            role = (Cons.ROLE)(int.Parse(memberRecord["role"].ToString()));

            if (memberRecord["team_id"].Equals(DBNull.Value))
                team_id = 0;
            else
                team_id = int.Parse(memberRecord["team_id"].ToString());

            if (memberRecord["company_id"].Equals(DBNull.Value))
                company_id = 0;
            else
                company_id = int.Parse(memberRecord["company_id"].ToString());
        }
        public bool Login(string userName, string pass)
        {
            string err = "";
            this.id = member.getUserByUsername(userName, pass, ref err);
            if (this.id == 0)
                return false;
            // Login Success
            setValueForInstance(this.id);
            return true;
        }
        #endregion

        #region Field
        BSMember member = null;
        int id;
        string name;
        Cons.ROLE role;
        int team_id;
        string username;
        string password;
        int company_id;
        #endregion

        #region Prop
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Cons.ROLE Role { get => role; set => role = value; }
        public int Team_id { get => team_id; set => team_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Company_id { get => company_id; set => company_id = value; }
        #endregion
    }
}
