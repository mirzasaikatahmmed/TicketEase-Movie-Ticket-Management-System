using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketEase___Movie_Ticket_Management_System.Controller;
using TicketEase___Movie_Ticket_Management_System.Model;

namespace TicketEase___Movie_Ticket_Management_System.View.Ticket
{
    public partial class Purchase : Form
    {
        MovieController movieController = new MovieController();
        TicketController ticketController = new TicketController();
        private DataTable movieData;
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            txtCustomerName.Text = $"Name: {User.Current.Name}";

            movieData = movieController.GetAllMovies();

            cmbMovies.DisplayMember = "Title";
            cmbMovies.ValueMember = "Id";
            cmbMovies.DataSource = movieData;
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedIndex == -1) return;

            DataRowView selected = cmbMovies.SelectedItem as DataRowView;

            txtGenre.Text = $"Genre: {selected["Genre"].ToString()}";
            txtDuration.Text = $"Duration: {selected["DurationMinutes"].ToString() + " min"}";
            txtShowDate.Text = $"Show Date: {Convert.ToDateTime(selected["ShowTime"]).ToString("dd-MM-yyyy")}";
            txtShowTime.Text = $"Show Time: {Convert.ToDateTime(selected["ShowTime"]).ToString("hh:mm tt")}";
            txtPrice.Text = selected["Price"].ToString();
            txtAvailableTickets.Text = $"Available Tickets: {selected["TicketQuantity"].ToString()}";

            CalculateTotal();
        }

        private void txtShowTime_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (cmbMovies.SelectedIndex == -1) return;

            decimal price = Convert.ToDecimal(txtPrice.Text);
            int quantity = (int)numericUpDown1.Value;
            txtTotalAmount.Text = (price * quantity).ToString("0.00");
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a movie.");
                return;
            }

            int quantity = (int)numericUpDown1.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Please select at least 1 ticket.");
                return;
            }

            DataRowView selected = cmbMovies.SelectedItem as DataRowView;
            int movieId = Convert.ToInt32(selected["Id"]);
            int available = Convert.ToInt32(selected["TicketQuantity"]);
            decimal price = Convert.ToDecimal(selected["Price"]);
            decimal total = price * quantity;

            if (quantity > available)
            {
                MessageBox.Show("Not enough tickets available.");
                return;
            }

            Model.Ticket ticket = new Model.Ticket
            {
                UserId = User.Current.Id,
                MovieId = movieId,
                Quantity = quantity,
                TotalAmount = total,
                PurchaseDate = DateTime.Now
            };

            bool success = ticketController.PurchaseTicket(ticket);
            if (success)
            {
                MessageBox.Show("Ticket purchased successfully.");
                Purchase_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Purchase failed.");
            }
        }
    }
}
