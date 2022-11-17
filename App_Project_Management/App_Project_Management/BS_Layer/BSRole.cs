using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagerApp.DB_Layer;
using System.Data;

namespace App_Project_Management.BS_Layer
{
    internal class BSRole
    {
        DBMain db = null;
        public BSRole()
        {
            db = new DBMain();
        }
        public DataTable getRole()
        {
            string sqlString = "EXEC getRole";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0];
        }

    }
}
