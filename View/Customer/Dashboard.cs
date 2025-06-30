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

namespace TicketEase___Movie_Ticket_Management_System.View.Customer
{
    public partial class Dashboard : Form
    {
        MovieController movieController = new MovieController();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {User.Current.Name}";

            try
            {
                dgvMovies.DataSource = movieController.GetAllMovies();
                dgvMovies.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load movies: " + ex.Message);
            }
        }
    }
}
