using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }//program ends
    
    public class NotificationSystem
    {
        public List<string> UserEmailList = new List<string>();

        //Declare Delegate
        public delegate void PublishMessageDel(string message);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        public void PublishMessage(CarRegistration newCar)
        {
            // Construct the message with car details
            string message = $"A new car has arrived!\n" +
                            $"Model: {newCar.model}\n" +
                            $"Color: {newCar.color}\n" +
                            $"Mileage: {newCar.mileage}\n" +
                            $"Price: {newCar.price}\n" +
                            $"Year: {newCar.year}\n";

            // Invoke Delegate with the constructed message
            publishmsg.Invoke(message);
        }
    }//NotificationSystem ends

    public class CarRegistration
    {
        public string model;
        public string color;
        public string mileage;
        public string price;
        public string year;

        public CarRegistration(string model, string color, string mileage, string price, string year)
        {
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.mileage = mileage;
        }

    }//CarRegistration ends

    public class User
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phoneNum;


        public User(string firstName, string lastName, string email, string phoneNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.email = email;
        }

        public void sendNotification(string message)
        {
            Console.WriteLine("The message" + "\"" + message + "\" has already sent to " + this.email);
        }

        public void Subscribe(NotificationSystem notificationSystem)
        {
            notificationSystem.publishmsg += sendNotification;
            notificationSystem.UserEmailList.Add(this.email);
        }

        public void UnSubscribe(NotificationSystem notificationSystem)
        {
            notificationSystem.publishmsg -= sendNotification;
            notificationSystem.UserEmailList.Remove(this.email);
        }
    }//User ends


}
