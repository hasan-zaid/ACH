using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class customerNumber
    {
        private string cus_id;
        private string cus_name;
        private string cus_contact;
        private string cus_password;
       

        public string Cus_id { get { return cus_id; } set { cus_id = value; } }
        public string Cus_name { get { return cus_name; } set { cus_name = value; } }
        public string Cus_contact { get { return cus_contact; } set { cus_contact = value; } }
        public string Cus_password { get { return cus_password; } set { cus_password = value; } }
        

        public customerNumber(string Cus_id, string Cus_name, string Cus_contact, string Cus_password)
        {
            this.cus_id = Cus_id;
            this.cus_name = Cus_name;
            this.cus_contact = Cus_contact;
            this.cus_password = Cus_password;
            
        }

        public customerNumber(string Cus_id)
        {
            this.cus_id = Cus_id;
        }

        public void change_contact(string contact)
        {
            this.cus_contact = contact;
        }

        public void change_password(string password)
        {
            this.cus_password = password;
        }
    }
}
