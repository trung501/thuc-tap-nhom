using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Data Source=TRUNG\TRUNG;Initial Catalog=HotelManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

          //private string connectionStr = @"Data Source=THIEN-AI\THIENAI;Initial Catalog=HotelManagement;Integrated Security=True";
          //private string connectionStr = @"Data Source=.\sqlexpress;Initial Catalog=HotelManagement;Integrated Security=True";
          public DataTable ExecuteQuery(string query, object[] parameter = null)
          {
               DataTable data = new DataTable();
               using (SqlConnection connection = new SqlConnection(connectionStr))
               {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    AddParameter(query, parameter, command);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
               }
               return data;
          }

          private DataProvider() { }
     }
}