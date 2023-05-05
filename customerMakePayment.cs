using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class customerMakePayment
    {
        public void processPayment(int amount, string customer_id, string service_id, string urgency)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            
            string command_1 = "insert into requested_services(service_id, cus_id, service_completion, reviewed, amount_paid, service_urgency, order_date) values ( @service_id , @customer_id , 0, 0, @amount , @urgency , @date );";
            SqlCommand cmd_1 = new SqlCommand(command_1, con);

            string uppercase = customer_id.ToUpper();
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");

            cmd_1.Parameters.AddWithValue("@date", sqlFormattedDate);
            cmd_1.Parameters.AddWithValue("@service_id", service_id);
            cmd_1.Parameters.AddWithValue("@customer_id", uppercase);
            cmd_1.Parameters.AddWithValue("@amount", amount);
            cmd_1.Parameters.AddWithValue("@urgency", urgency);
            cmd_1.ExecuteNonQuery();
        }
    }
}
