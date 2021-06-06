using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Virtual_Mente.Controllers
{
    public class ConnectionDBController : Controller
    {
        String bondConnection = "Data source=LAPTOP-PHDA6TV8\\MSSQLSERVER19;Initial Catalog=VirtualMente; Integrated Security=True";
        public SqlConnection connection = new SqlConnection ();


        public ConnectionDBController()
        {
            connection.ConnectionString = bondConnection;
        }

        public void openConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection open");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to open "+ex.Message);
            }

        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
