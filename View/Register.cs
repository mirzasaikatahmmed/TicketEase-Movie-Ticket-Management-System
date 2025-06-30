using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TicketEase___Movie_Ticket_Management_System.Controller;
using TicketEase___Movie_Ticket_Management_System.Model;
using TicketEase___Movie_Ticket_Management_System.Model.ViewModels;

namespace TicketEase___Movie_Ticket_Management_System.View
{
    public partial class Register : Form
    {
        AccountController accountController = new AccountController();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string phone = tbPhoneNo.Text.Trim();
            DateTime dob = dtpDOB.Value;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            RegisterViewModel model = new RegisterViewModel
            {
                Name = tbEmail.Text,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                PhoneNumber = tbEmail.Text,
                DateOfBirth = dtpDOB.Value
            };


            try
            {
                bool success = accountController.Register(model);
                if (success)
                {
                    MessageBox.Show("Registration successful! You can now log in.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
