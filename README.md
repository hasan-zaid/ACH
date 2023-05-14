# ACH

The system has 4 types of users with each type having its own access level assigned at login. Alongside the login and update profile functionalities, the system users have unique functions for each user type. Customers can raise a laptop service request and make a virtual payment. They can also track the status of any ongoing services they requested. Receptionists can view pending payments and approve or reject them. They can also register new customer accounts. Technicians can view service requests and initiate a request. They can update the status of request and update the estimated time of completion. Admins can view users accounts of all types and delete them if needed. They can also create a new user account of their desired type. Finally, admins can generate monthly reports of all services and payments.

To run the application, follow the below steps: 
- Access the App.config file and change the location under connectionString variable of the "ACH-DB.mdf" file to the new location on your system.
- Run SQL Server Management Studio and connect to the "ACH-DB.mdf" database image file under "bin>Debug".
- Run the "ACH.exe" file under "bin>Debug".
