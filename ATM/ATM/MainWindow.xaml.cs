using System;
using System.Threading;
using System.Windows;

namespace ATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Atm atm;
        private Account account;


        //public MainWindow(string CardNumber, Atm atm, Account acc)
        //{
        //    InitializeComponent();
        //    account = acc;
        //    Greetings.Text += $"Good {DayTime()} {account.FullName}";
        //    Card.Content += CardNumber;
        //}

        public MainWindow(string CardNumber,Account acc)
        {
            atm =new Atm(1, "Liberty prospect 10", 25000.0);
            InitializeComponent();
            account = acc;
            Greetings.Text += $"Good {DayTime()} {account.FullName}";
            Card.Content += CardNumber;
        }

        private void CheckBallance(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Your ballance : {account.Ballance}");
        }

        private void WithdrawMoney(object sender, RoutedEventArgs e)
        {
            InputBox inputBox = new InputBox("How Much");
            inputBox.Show();
            int a = 0;
            
            //while (inputBox.b!=true)
            //{
            //    Thread.Sleep(1000);
            //}

            
            


        }



        private void RefillBallance(object sender, RoutedEventArgs e)
        {
            InputBox inputBox = new InputBox("How Much");
            inputBox.Show();
            atm.AddOnAccount(inputBox.amount, account);
            MessageBox.Show($"ThankYou.\n Your ballance : {account.Ballance}.");
        }

        private void RefillPhone(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Available Soon");

        }

        private void BuyTicket(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Available Soon");
        }

        private void Other(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Available Soon!");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public static string DayTime()
        {
            DateTime dateTime = new DateTime();
            if (dateTime.Hour >= 5 && dateTime.Hour < 12)
            {
                return "morning";
            }
            else if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "day";
            }
            else if (dateTime.Hour >= 18)
            {
                return "evening";
            }
            else
            {
                return "night";
            }
        }


    }
}
