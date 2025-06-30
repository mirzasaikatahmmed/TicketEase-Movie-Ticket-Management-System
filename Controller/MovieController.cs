using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketEase___Movie_Ticket_Management_System.Model;

namespace TicketEase___Movie_Ticket_Management_System.Controller
{
    public class MovieController
    {
        private Movie movieModel = new Movie();

        public DataTable GetAllMovies()
        {
            return movieModel.GetAll();
        }
    }
}
