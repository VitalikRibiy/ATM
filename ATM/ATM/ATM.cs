using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Atm
    {
        public int Id { get; private set; }
        public string Adress { get; private set; }
        public double Cash { get; private set; }


        public Atm(int id,string adress,double cash)
        {
            Id = id;
            Adress = adress;
            Cash = cash;
        }

        public bool Withdraw(double amount)
        {
            if(Cash>=amount)
            {
                Cash -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddOnAccount(double amount,Account account)
        {
            account.Add(amount);
            Add(amount);
        }

        public void Add(double amount)
        {
            Cash += amount;
        }

    }
}
