using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        public Form1()
        {
            InitializeComponent();
        }

        private void userManagementBtn_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(notificationSystem);
            userManagementForm.ShowDialog();
        }

        private void carManagementBtn_Click(object sender, EventArgs e)
        {
            CarManagementForm carManagementForm = new CarManagementForm(notificationSystem);
            carManagementForm.ShowDialog();
        }
    }
}
