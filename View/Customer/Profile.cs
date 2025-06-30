using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketEase___Movie_Ticket_Management_System.Model;

namespace TicketEase___Movie_Ticket_Management_System.View.Customer
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var user = User.Current;

            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.PhoneNumber;
            txtDOB.Text = user.DateOfBirth.ToString("dd-MM-yyyy");
            txtRole.Text = user.Role;
            txtCreatedAt.Text = user.CreatedAt.ToString("dd-MM-yyyy hh:mm tt");
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
            this.Close();
        }
    }
}
