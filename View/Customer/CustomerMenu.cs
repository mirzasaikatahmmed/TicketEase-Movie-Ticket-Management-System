using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketEase___Movie_Ticket_Management_System.View.Customer
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }
        private void LoadFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Dashboard());
        }

        private void btnPurchaseTickets_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Ticket.Purchase());
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Ticket.History());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
