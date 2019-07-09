using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ATM
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Atm atm;

        public Window1()
        {
            atm = new Atm(1, "Liberty prospect 10", 25000.0);
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            string symbol= button.Content.ToString();
            
            

            switch(symbol)
            {
                case "Enter":
                    if(Password.Password.Length==4&&CardNumber.Text.Length==16)
                    {
                        Account account = new Account(CardNumber.Text, Password.Password, "Vitalii","Ribii","Volodymyrovych",1000.0);

                        //MainWindow mainWindow = new MainWindow(CardNumber.Text.ToString(),atm,account);
                        MainWindow mainWindow = new MainWindow(CardNumber.Text.ToString(),account);
                        this.Close();
                        mainWindow.Show();
                    }
                    else
                    {
                        if(Password.Password.Length!=4)
                        {
                            MessageBox.Show("Wrong Password");
                        }
                        if(CardNumber.Text.Length!=16)
                        {
                            MessageBox.Show("Wrong Card Number");
                        }
                    }
                    break;
                case "Del":
                    if(Password.Password.Length!=0)
                    {
                        Password.Password = Password.Password.Remove(Password.Password.Length - 1);
                    }
                    break; 
                default:
                    if(Password.Password.Length<4)
                    Password.Password += symbol;
                    break;
            }
        }
    }
}
