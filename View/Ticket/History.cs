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
    public partial class History : Form
    {
        TicketController ticketController = new TicketController();
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            dgvPurchaseHistory.DataSource = ticketController.GetPurchaseHistory(User.Current.Id);
            dgvPurchaseHistory.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
