using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class declinePayment
    {
        SqlConnection con;


        public void decline(int i)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string command_2 = "update requested_services set payment_accepted = 0, reviewed = 1 where request_no = @ID";
            SqlCommand cmd_2 = new SqlCommand(command_2, con);
            cmd_2.Parameters.AddWithValue("@ID", i);
            
            cmd_2.ExecuteNonQuery();
            con.Close();
        }
    }
}
