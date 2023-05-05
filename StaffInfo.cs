using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class StaffInfo
    {
        private string staff_id;
        private string staff_name;
        private string staff_contact;
        private string staff_password;
        private string staff_birthdate;

        public string Staff_id { get { return staff_id; } set { staff_id = value; } }
        public string Staff_name { get { return staff_name; } set { staff_name = value; } }
        public string Staff_contact { get { return staff_contact; } set { staff_contact = value; } }
        public string Staff_password { get { return staff_password; } set { staff_password = value; } }
        public string Staff_birthdate { get { return staff_birthdate; } set { staff_birthdate = value; } }

        public StaffInfo(string Staff_id, string Staff_name, string Staff_contact, string Staff_password, string Staff_birthdate)
        {
            this.staff_id = Staff_id;
            this.staff_name = Staff_name;
            this.staff_contact = Staff_contact;
            this.staff_password = Staff_password;
            this.staff_birthdate = Staff_birthdate;
        }

        public StaffInfo(string Staff_id)
        {
            this.staff_id = Staff_id;
        }

        public StaffInfo() { }

        public void change_contact(string contact)
        {
            this.staff_contact = contact;
        }

        public void change_password(string password)
        {
            this.staff_password = password;
        }

        public int CreateStaff(string query, string query2)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand(query + query2, con);
            cmd.Parameters.AddWithValue("@id", Staff_id);
            cmd.Parameters.AddWithValue("@name", Staff_name);
            cmd.Parameters.AddWithValue("@contact", Staff_contact);
            cmd.Parameters.AddWithValue("@password", Staff_password);
            cmd.Parameters.AddWithValue("@bdate", Staff_birthdate);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            if (x != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{staff_id}\t\t{staff_name}\t\t\t{staff_contact}";
        }
    }
}
