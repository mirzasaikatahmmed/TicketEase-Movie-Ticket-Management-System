using System;
using System.Collections.Generic;
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
    }

}
