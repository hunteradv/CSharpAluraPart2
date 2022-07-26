using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bytebank
{
    public class CheckingAccount
    {
        public string Holder { get; set; }
        public int Agency { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; } = 100;

        public bool Withdraw(double value)
        {
            if (this.Balance < value)
            {
                return false;
            }
            else
            {
                this.Balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            this.Balance += value;
        }

        public bool Transfer(double value, CheckingAccount account)
        {
            if(this.Balance < value)
            {
                return false;
            }
            else
            {
                this.Balance -= value;
                account.Deposit(value);

                return true;
            }
        }
    }
}
