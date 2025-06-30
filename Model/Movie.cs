using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketEase___Movie_Ticket_Management_System.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ShowTime { get; set; }
        public decimal Price { get; set; }
        public int TicketQuantity { get; set; }
        public DateTime CreatedAt { get; set; }

        private SqlDbDataAccess db = new SqlDbDataAccess();

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Movies";
            SqlCommand cmd = db.GetQuery(query);

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            adapter.Fill(table);
            cmd.Connection.Close();

            return table;
        }

        public bool ReduceTicketQuantity(int movieId, int quantity)
        {
            string query = @"UPDATE Movies SET TicketQuantity = TicketQuantity - @Qty WHERE Id = @Id AND TicketQuantity >= @Qty";
            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@Qty", quantity);
            cmd.Parameters.AddWithValue("@Id", movieId);

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows > 0;
        }
    }

}
