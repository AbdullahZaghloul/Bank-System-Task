using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Task
{
    internal class TrustAccount:SavingsAccount
    {
        private int count = 3;
        private DateTime currentYear = DateTime.Now ;
        public TrustAccount()
        {
            
        }
        public TrustAccount(string name):base(name)
        {
            
        }
        public TrustAccount(string name,double balance):base(name,balance)
        {
            
        }
        public TrustAccount(string name,double balance,double interestReate):base(name,balance)
        {
            InterestRate = interestReate;
        }
        public override bool Deposit(double amount)
        {
            if(amount>=5000)
                return base.Deposit(amount+50);
            else
                return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (DateTime.Now.Year > currentYear.Year)
            {
                count = 3;
                currentYear = DateTime.Now;
            }
            if (amount < (Balance * 20 / 100) && count > 0 && Balance >= amount)
            {
                count--;
                return base.Withdraw(amount);
               
            } 
            return false;

        }


    }
}
