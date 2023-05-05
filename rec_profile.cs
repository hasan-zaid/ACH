using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class rec_profile
    {
        private string name;
        private string phoneNumber;

        SqlConnection con;

        public string Name { get { return name; } set { name = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value;} }


        public void fetch(string id)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();

            string command_1 = "select rec_name, rec_phone_number from receptionists where rec_id = @id";
            SqlCommand cmd_1 = new SqlCommand(command_1, con);
            cmd_1.Parameters.AddWithValue("@id", id);
            SqlDataReader info = cmd_1.ExecuteReader();

            while (info.Read())
            {
                name = info.GetString(0);
                phoneNumber = info.GetString(1);
            }
            info.Close();
            con.Close();
        }
    }
}
