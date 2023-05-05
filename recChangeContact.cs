using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class recChangeContact
    {
        string id;
        string number;
        SqlConnection con;
        SqlCommand cmd_1;

        public recChangeContact(string rec_id, string newNumber)
        {
            id = rec_id;
            number = newNumber;
        }
        public string changeContact()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();

            string command = "update receptionists set rec_phone_number = @new where rec_id = @id";
            cmd_1 = new SqlCommand(command, con);
            cmd_1.Parameters.AddWithValue("@new", number);
            cmd_1.Parameters.AddWithValue("@id", id);
            int check = cmd_1.ExecuteNonQuery();
            con.Close();

            if (check != 0)
            {
                return "Your phone number is changed successfully";
            }
            else
            {
                return "Couldn't change your phone number !";
            }
        }
    }
}
