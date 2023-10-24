using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CarManagementForm : Form
    {
        private NotificationSystem notificationSystem = new NotificationSystem();

        public CarManagementForm(NotificationSystem notificationSystem)
        {
            InitializeComponent();
            this.notificationSystem = notificationSystem;
        }


        private void submitAndPublishBtn_Click(object sender, EventArgs e)
        {
            string model = modelTextBox.Text;
            string mileage = mileageTextBox.Text;
            string color = colorTextBox.Text;
            string price = priceTextBox.Text;
            string year = yearTextBox.Text;


            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(mileage) || string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CarRegistration newCar = new CarRegistration(model, color, mileage, price, year);
                notificationSystem.PublishMessage(newCar);

                StringBuilder message = new StringBuilder("New Car Details:\n");
                message.AppendLine($"Model: {newCar.model}");
                message.AppendLine($"Color: {newCar.color}");
                message.AppendLine($"Mileage: {newCar.mileage}");
                message.AppendLine($"Price: {newCar.price}");
                message.AppendLine($"Year: {newCar.year}");
                message.AppendLine("\nThe above message was sent to the following email addresses:\n");

                foreach (string userEmailAddress in notificationSystem.UserEmailList)
                {
                    message.AppendLine($"{userEmailAddress}");
                }

                MessageBox.Show(message.ToString(), "Message Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
