using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserManagementForm : Form
    {
        private NotificationSystem notificationSystem = new NotificationSystem();

        public UserManagementForm(NotificationSystem notificationSystem)
        {
            InitializeComponent();
            this.notificationSystem = notificationSystem;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string userFirstName = firstNameTextBox.Text;
            string userLastName = lastNameTextBox.Text;
            string userEmail = emailTextBox.Text;
            string userPhoneNo = phoneNoTextBox.Text;
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$";

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Please provide your email address";
                emailErrorLabel.ForeColor = Color.Red;
                emailErrorLabel.Visible = true;

                return;
            }

            if (!Regex.IsMatch(userEmail, pattern))
            {
                emailErrorLabel.Text = "Invalid email address";
                emailErrorLabel.ForeColor = Color.Red;
                emailErrorLabel.Visible = true;

                return;
            }

            if (addUserBtn.Checked) 
            {
                if (!notificationSystem.UserEmailList.Contains(userEmail))
                {
                    User user = new User(userFirstName, userLastName, userEmail, userPhoneNo);
                    user.Subscribe(notificationSystem);
                    MessageBox.Show($"User with email address as -- {userEmail} subscribes");
                }
                else
                {
                    MessageBox.Show("This email is already subscribed");
                }
            }

            if (delUserBtn.Checked)
            {
                if (notificationSystem.UserEmailList.Contains(userEmail))
                {
                    User user = new User(userFirstName, userLastName, userEmail, userPhoneNo);
                    user.UnSubscribe(notificationSystem);
                    MessageBox.Show($"User with email address as -- {userEmail} unsubscribes");
                }
                else
                {
                    MessageBox.Show($"User with email address as -- {userEmail} already unsubscribed");
                }
            }
        }
    }
}
