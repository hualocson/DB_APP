using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Project_Management.Model
{
    class CompanyDetailsModel
    {
        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string abbreviation;
        public string Abbreviation
        {
            get { return abbreviation; }
            set { abbreviation = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public CompanyDetailsModel()
        {
            this.companyName = "";
            this.abbreviation = "";
            this.address = "";
            this.phone = "";
            this.id = -1;
        }
        public CompanyDetailsModel(string CompanyName,string Abbreviation, string Address, string Phone, int Id)
        {
            this.companyName = CompanyName;
            this.abbreviation = Abbreviation;
            this.address = Address;
            this.phone = Phone;
            this.id = Id;
        }
    }
}
