using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AudioPlayer
{
    public class ActivityLOG
    {
        private string connectionString;

        public ActivityLOG()
        {
            connectionString = "Data Source=R-A-H\\SQLEXPRESS;Initial Catalog=AudioPlayer;Integrated Security=True";
        }

        public void InsertActivityLog(string name, string currentFormName, string userVisited)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ActivityLog (Name, DateTime, Form_Name, UserVisited) VALUES (@Name, @DateTime, @Form_Name, @UserVisited)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@Form_Name", currentFormName);
                    command.Parameters.AddWithValue("@UserVisited", userVisited);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ClearVisitedForms()
        {
            ClsVisitedForms.VisitedForms.Clear();
        }
    }
}
