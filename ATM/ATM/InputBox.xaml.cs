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
    /// Interaction logic for InputBox.xaml
    /// </summary>
    public partial class InputBox : Window
    {
        public double amount;
        public bool b;

        public InputBox(string mes)
        {
            InitializeComponent();
            b = false;
            Ask.Content = mes;
              
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            amount = Convert.ToDouble(Answer.Text);
            b = true;
            Close();
        }
    }
}
