using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class acceptPayment
    {
        SqlConnection con;

       

        public void accept(int number,int money, string id, string name, string service, string rec_id, string rec_name, string urgency, string service_id)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string command_2 = "update requested_services set payment_accepted = 1, reviewed = 1 where request_no = @ID";
            SqlCommand cmd_2 = new SqlCommand(command_2, con);
            cmd_2.Parameters.AddWithValue("@ID", number);
            cmd_2.ExecuteNonQuery();

            string command_3 = "insert into receipts values ('" + id + " : " + name + " attempted payement was accepted by receptionist: " + rec_id + " : " + rec_name + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', ' " + service + "', " + number + ", " + money + "); ";
            SqlCommand cmd_3 = new SqlCommand(command_3, con);
            cmd_3.ExecuteNonQuery();

            string comand = "select Total_Income from Total_Income;";
            SqlCommand cd = new SqlCommand(comand, con);
            SqlDataReader reader = cd.ExecuteReader();
            int total_income = 0;
            while (reader.Read())
            {
                total_income = reader.GetInt32(0) + money;

            }
            reader.Close();
            string comand_2 = "update Total_Income set Total_Income = " + total_income + ";";
            SqlCommand cd_2 = new SqlCommand(comand_2, con);
            cd_2.ExecuteNonQuery();


            if (urgency == "urgent")
            {
                string command_4 = "select urgent_count, income from income_report where service_id = @service_id ;";
                SqlCommand cmd_4 = new SqlCommand(command_4, con);
                cmd_4.Parameters.AddWithValue("@service_id", service_id);


                SqlDataReader read = cmd_4.ExecuteReader();
                if (read.Read())
                {
                    int urgent_count = read.GetInt32(0) + 1;
                    int income = read.GetInt32(1) + money;
                    read.Close();
                    string command_5 = "update income_report set urgent_count = @urgent_count, income = @income where service_id = @id ;";
                    SqlCommand cmd_5 = new SqlCommand(command_5, con);
                    cmd_5.Parameters.AddWithValue("@urgent_count", urgent_count);
                    cmd_5.Parameters.AddWithValue("@income", income);
                    cmd_5.Parameters.AddWithValue("@id", service_id);
                    cmd_5.ExecuteNonQuery();
                }
                
            }
            else if (urgency == "normal")
            {
                string command_6 = "select normal_count, income from income_report where service_id = @service_id ;";
                SqlCommand cmd_6 = new SqlCommand(command_6, con);
                cmd_6.Parameters.AddWithValue("@service_id", service_id);


                SqlDataReader read_2 = cmd_6.ExecuteReader();
                if (read_2.Read())
                {
                    int normal_count = read_2.GetInt32(0) + 1;
                    int income = read_2.GetInt32(1) + money;
                    read_2.Close();
                    string command_7 = "update income_report set normal_count = @normal_count, income = @income where service_id = @id ;";
                    SqlCommand cmd_7 = new SqlCommand(command_7, con);
                    cmd_7.Parameters.AddWithValue("@normal_count", normal_count);
                    cmd_7.Parameters.AddWithValue("@income", income);
                    cmd_7.Parameters.AddWithValue("@id", service_id);
                    cmd_7.ExecuteNonQuery();
                }
            }
        }
    }
}
