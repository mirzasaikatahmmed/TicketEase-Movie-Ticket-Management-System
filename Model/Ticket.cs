using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketEase___Movie_Ticket_Management_System.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }

        private SqlDbDataAccess db = new SqlDbDataAccess();

        public bool Add()
        {
            string query = @"INSERT INTO Tickets (UserId, MovieId, Quantity, TotalAmount, PurchaseDate)
                         VALUES (@UserId, @MovieId, @Quantity, @TotalAmount, @PurchaseDate)";

            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@MovieId", MovieId);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows > 0;
        }

        public DataTable GetPurchaseHistory(int userId)
        {
            string query = @"
        SELECT 
            t.Id AS TicketID,
            m.Title AS Movie,
            m.Genre,
            m.ShowTime,
            t.Quantity,
            t.TotalAmount,
            t.PurchaseDate
        FROM Tickets t
        INNER JOIN Movies m ON t.MovieId = m.Id
        WHERE t.UserId = @UserId
        ORDER BY t.PurchaseDate DESC";

            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@UserId", userId);

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            cmd.Connection.Open();
            adapter.Fill(table);
            cmd.Connection.Close();

            return table;
        }
    }


}
