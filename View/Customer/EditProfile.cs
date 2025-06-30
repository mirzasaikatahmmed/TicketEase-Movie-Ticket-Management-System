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
    public partial class EditProfile : Form
    {
        CustomerController custormerController = new CustomerController();
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var user = User.Current;

            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.PhoneNumber;
            txtDOB.Text = user.DateOfBirth.ToString("yyyy-MM-dd");
            txtRole.Text = user.Role;
            txtPassword.Text = user.Password;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                User updatedUser = new User
                {
                    Id = User.Current.Id,
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    DateOfBirth = DateTime.Parse(txtDOB.Text.Trim()),
                    Role = txtRole.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    CreatedAt = User.Current.CreatedAt
                };

                bool success = custormerController.UpdateProfile(updatedUser);

                if (success)
                {
                    MessageBox.Show("Profile updated successfully.");
                    User.Current = updatedUser;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
