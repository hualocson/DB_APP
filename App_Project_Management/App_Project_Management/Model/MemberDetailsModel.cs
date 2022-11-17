using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace App_Project_Management.Model
{
    class MemberDetailsModel
    {
        BS_Layer.BSMember blmember;

        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool gender;
        
        public bool Gender
        {
            get { return gender; }
            set
            {
                 gender = value;
            }
        }
        private int role_id;
        public int Role_id
        {
            get { return role_id; }
            set
            {
                role_id = value;
            }
        }

        private int role;
        public int Role
        {
            get { return role; }
            set
            {
                role = value;
            }
        }

        private int team_id;
        public int Team_id
        {
            get { return team_id; }
            set
            {
                team_id = value;
            }
        }
        private string team_name;
        public string Team_name
        {
            get { return team_name; }
            set
            {
                team_name = value;
            }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        private int company_id;
        public int Company_id
        {
            get { return company_id; }
            set
            {
                company_id = value;
            }
        }
        private string company_name;
        public string Company_name
        {
            get { return company_name; }
            set
            {
                company_name = value;
            }
        }
        private string abbreviation;
        public string Abbreviation
        {
            get { return abbreviation; }
            set
            {
                abbreviation = value;
            }
        }

        public MemberDetailsModel()
        {
            this.id = -1;
            this.name = "";
            this.gender = true;
            this.role_id = -1;
            this.role = -1;
            this.team_id = -1;
            this.team_name = "";
            this.username = "";
            this.password = "";
            this.company_id = -1;
            this.company_name = "";
            this.abbreviation = "";
        }
        public MemberDetailsModel(string Name, string Username, string Password,bool Gender, int Id)
        {
            this.id = Id;
            this.name = Name;
            this.gender = Gender;
            this.role_id = -1;
            this.role = -1;
            this.team_id = -1;
            this.team_name = "null";
            this.username = Username;
            this.password = Password;
            this.company_id = -1;
            this.company_name = "null";
            this.abbreviation = "null";
        }
        public MemberDetailsModel(int Id)
        {
            this.id = Id;
            blmember = new BS_Layer.BSMember();
            DataRow memberInfo = blmember.getMemberById(id).Rows[0];
            this.name = memberInfo["name"].ToString();
            this.gender = bool.Parse(memberInfo["gender"].ToString());
            if (!memberInfo["role"].Equals(System.DBNull.Value))
                this.role = int.Parse(memberInfo["role"].ToString());
            else this.role_id = -1;
            if (!memberInfo["team_id"].Equals(System.DBNull.Value))
                this.role = int.Parse(memberInfo["team_id"].ToString());
            else this.team_id = -1;
            if (!memberInfo["company_id"].Equals(System.DBNull.Value))
                this.company_id = int.Parse(memberInfo["company_id"].ToString());
            else this.company_id = -1;
            this.username = memberInfo["username"].ToString();
            this.password = memberInfo["password"].ToString();
        }
    }
}
