using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class register_cus
    {
        private string cus_name;
        private string cus_number;
        private string cus_pass;
        private string cus_id;
        int num;

        SqlConnection con;

        public void id_generator()
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();

            string Q = "select COUNT(cus_id) from customers;";
            SqlCommand cmd_1 = new SqlCommand(Q, con);
            SqlDataReader numOfRows = cmd_1.ExecuteReader();
            while (numOfRows.Read())
            {
                num = numOfRows.GetInt32(0);
            }
            numOfRows.Close();
            con.Close();

            num = num + 1;
            cus_id = "CU00" + num.ToString();
        }

        public string registerer(string name, string number, string password)
        {
            cus_name = name;
            cus_number = number;
            cus_pass = password;

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();

            string command_1 = "insert into customers values ( @id , @name , @number , @pass );";

            SqlCommand cmd_1 = new SqlCommand(command_1, con);
            cmd_1.Parameters.AddWithValue("@id", cus_id);
            cmd_1.Parameters.AddWithValue("@name", cus_name);
            cmd_1.Parameters.AddWithValue("@number", cus_number);
            cmd_1.Parameters.AddWithValue("@pass", cus_pass);
            int test = cmd_1.ExecuteNonQuery();

            string command_2 = "insert into users_login values ( @id , @pass , 'customer' , @name );";

            SqlCommand cmd_2 = new SqlCommand(command_2, con);
            cmd_2.Parameters.AddWithValue("@id", cus_id);
            cmd_2.Parameters.AddWithValue("@name", cus_name);
            cmd_2.Parameters.AddWithValue("@pass", cus_pass);
            int test_2 = cmd_2.ExecuteNonQuery();

            if (test != 0 & test_2 != 0)
            {
                con.Close();
                return "customer account was created successfully";
            }
            else
            {
                con.Close();
                return "Could not create customer account";
            }
           
        }
    }
}
