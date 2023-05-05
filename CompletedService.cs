using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    internal class CompletedService
    {
        private int _requestNumber;
        private string _serviceID;
        private string _serviceDescription;
        private int _amountPaid;
        private DateTime _orderDate;
        private DateTime _collectionDate;
        private string _serviceUrgency;
        private string _customerID;
        private string _technicianID;

        public int RequestNumber
        {
            get { return _requestNumber; }
            set { _requestNumber = value; }
        }

        public string ServiceID
        {
            get { return _serviceID; }
            set { _serviceID = value; }
        }

        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }
        public int AmountPaid
        {
            get { return _amountPaid; }
            set { _amountPaid = value;  }
        }

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        public DateTime CollectionDate
        {
            get { return _collectionDate; }
            set { _collectionDate = value; }
        }
        public string ServiceUrgency
        {
            get { return _serviceUrgency; }
            set { _serviceUrgency = value; }
        }
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string TechnicianID
        {
            get { return _technicianID; }
            set { _technicianID = value; }
        }

        public CompletedService(int requestNumber, string serviceID, string serviceDescription, int amountPaid, DateTime orderDate, DateTime collectionDate, string serviceUrgency, string customerID, string technicianID)
        {
            _requestNumber = requestNumber;
            _serviceID = serviceID;
            _serviceDescription = serviceDescription;
            _amountPaid = amountPaid;
            _orderDate = orderDate;
            _collectionDate = collectionDate;
            _serviceUrgency = serviceUrgency;
            _customerID = customerID;
            _technicianID = technicianID;
        }

        public int AddCompletedService()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO completed_services VALUES(@requestNo, @serviceId, @serviceDesc, @amountPaid, @orderDate, @collectionDate, @serviceUrgency, @cusID, @techID);", con);
            cmd.Parameters.AddWithValue("@requestNo", RequestNumber);
            cmd.Parameters.AddWithValue("@serviceID", ServiceID);
            cmd.Parameters.AddWithValue("@serviceDesc", ServiceDescription);
            cmd.Parameters.AddWithValue("@amountPaid", AmountPaid);
            cmd.Parameters.AddWithValue("@orderDate", OrderDate);
            cmd.Parameters.AddWithValue("@collectionDate", CollectionDate);
            cmd.Parameters.AddWithValue("@serviceUrgency", ServiceUrgency);
            cmd.Parameters.AddWithValue("@cusID", CustomerID);
            cmd.Parameters.AddWithValue("@techID", TechnicianID);
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
    }
}
