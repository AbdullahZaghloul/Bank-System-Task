using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Task
{
    internal class CheckingAccount:Account
    {
        private const double Fee = 1.50;
        public CheckingAccount()
        {
            
        }
        public CheckingAccount(string name) : base(name)
        {

        }
        public CheckingAccount(string name,double balance) : base(name, balance)
        {

        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }


    }
}
