using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class recChangePass
    {
        string id;
        string oldPassword;
        SqlConnection con;
        SqlCommand cmd_1;
        SqlCommand cmd_2;

        public recChangePass(string rec_id)
        {
            id = rec_id;
        }
        public string changePassword(string oldPass, string newPass)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string command_1 = "select rec_password from receptionists where rec_id = @re_id ";
            cmd_1 = new SqlCommand(command_1, con);
            cmd_1.Parameters.AddWithValue("@re_id", id);
            SqlDataReader retrieve = cmd_1.ExecuteReader();
            while (retrieve.Read())
            {
                oldPassword = retrieve.GetString(0);
            }
            retrieve.Close();
            con.Close();

            if (oldPassword == oldPass)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
                con.Open();
                string command_2 = "update receptionists set rec_password = @new where rec_id = @id";
                cmd_2 = new SqlCommand(command_2, con);
                cmd_2.Parameters.AddWithValue("@new", newPass);
                cmd_2.Parameters.AddWithValue("@id", id);
                int check = cmd_2.ExecuteNonQuery();


                string command_3 = "update users_login set user_password = @new where user_id = @id ";
                SqlCommand cmd_3 = new SqlCommand(command_3, con);
                cmd_3.Parameters.AddWithValue("@new", newPass);
                cmd_3.Parameters.AddWithValue("@id", id);
                int check_2 = cmd_3.ExecuteNonQuery();
                con.Close();



                if (check != 0 & check_2 != 0)
                {
                    return "Password is successfully updated !";
                }
                else
                {
                    return "Failed to updae the password !";
                }
            }
            else
            {
                return "The old password you entered is incorrect !";
            }
        }
    }
}