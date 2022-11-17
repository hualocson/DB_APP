using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.Model
{
    class TeamDetailsModel
    {
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
        private string abbreviation;
        public string Abbreviation
        {
            get { return abbreviation; }
            set { abbreviation = value; }
        }
        private int team_lead;
        public int Team_lead
        {
            get { return team_lead; }
            set
            {
                team_lead = value;
            }
        }
        private bool is_deleted;

        public bool Is_deleted
        {
            get { return is_deleted; }
            set
            {
                is_deleted = value;
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
        public TeamDetailsModel()
        {
            this.id = -1;
            this.name = "";
            this.abbreviation = "";
            this.team_lead = -1;
            this.is_deleted = false;
            this.company_id = -1;
        }
        public TeamDetailsModel(int Company_id)
        {
            this.name = "";
            this.abbreviation = "";
            this.company_id = Company_id;
            this.id = -1;
            this.team_lead = -1;
            this.is_deleted = false;
        }
    }
}
