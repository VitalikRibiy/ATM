using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string Password { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Fathername { get; set; }
        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {Fathername}";
            }
        }
        public double Ballance { get; private set; }

        public Account(string card_number,string pass,string name,string sur,string fath,double ballance)
        {
            CardNumber = card_number;
            Password = pass;
            Name = name;
            Surname = sur;
            Fathername = fath;
            Ballance = ballance;
        }

        public void Add(double amount)
        {
            Ballance += amount;
        }

        public bool Withdraw(double amount)
        {
            if(amount>Ballance)
            {
                return false;
            }
            else
            {
                Ballance -= amount;
                return true;
            }
        }

    }
}
