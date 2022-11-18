using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.Model
{
    public class Cons
    {
        public enum ROLE
        {
            SA = 4,
            PM = 3,
            TL = 2,
            TM = 1,
        }
        public enum TASK_STATUS
        {
            PENDING = 4,
            TODO = 3,
            DONE = 2,
            INPROGRESS = 1,
            UNDEFINE = 0,
        }
    }
}
