using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketEase___Movie_Ticket_Management_System.Model;

namespace TicketEase___Movie_Ticket_Management_System.Controller
{
    public class TicketController
    {
        private Ticket ticketModel = new Ticket();
        private Movie movieModel = new Movie();

        public bool PurchaseTicket(Ticket ticket)
        {
            bool stockReduced = movieModel.ReduceTicketQuantity(ticket.MovieId, ticket.Quantity);
            if (!stockReduced)
            {
                return false;
            }

            return ticket.Add();
        }

        public DataTable GetPurchaseHistory(int userId)
        {
            Ticket ticket = new Ticket();
            return ticket.GetPurchaseHistory(userId);
        }
    }
}
