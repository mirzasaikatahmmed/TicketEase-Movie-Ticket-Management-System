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
using TicketEase___Movie_Ticket_Management_System.Model.ViewModels;
using TicketEase___Movie_Ticket_Management_System.View;
using TicketEase___Movie_Ticket_Management_System.View.Customer;
using static System.Collections.Specialized.BitVector32;

namespace TicketEase___Movie_Ticket_Management_System
{
    public partial class Login : Form
    {
        AccountController accountController = new AccountController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            var loginModel = new LoginViewModel { Email = email, Password = password };
            var controller = new AccountController();
            var user = controller.Login(loginModel);

            if (user != null)
            {
                MessageBox.Show("Welcome, " + User.Current.Name);
                new CustomerMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Invalid credentials.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
