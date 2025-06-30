using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketEase___Movie_Ticket_Management_System.Model;
using TicketEase___Movie_Ticket_Management_System.Model.ViewModels;

namespace TicketEase___Movie_Ticket_Management_System.Controller
{
    public class AccountController
    {
        private User userModel = new User();

        public User Login(LoginViewModel model)
        {
            return userModel.Login(model.Email, model.Password);
        }
        public bool Register(RegisterViewModel model)
        {
            User user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,
                CreatedAt = DateTime.Now
            };

            return user.Register();
        }

    }
}
