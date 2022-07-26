using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Bytebank
{
    public class CheckingAccount
    {
        private Client Holder { get; set; }

        public static int TotalAccountsCreated { get; private set; }

        private int _agency;
        public int Agency 
        {
            get 
            {
                return _agency;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _agency = value;
            } 
        }
        public int Number { get; set; }

        private double _balance = 100;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }

        public CheckingAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;

            TotalAccountsCreated++;
        }

        public bool Withdraw(double value)
        {
            if (Balance < value)
            {
                return false;
            }
            else
            {
                Balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public bool Transfer(double value, CheckingAccount account)
        {
            if(this.Balance < value)
            {
                return false;
            }
            
            Balance -= value;
            account.Deposit(value);

            return true;            
        }
    }
}
