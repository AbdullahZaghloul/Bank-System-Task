using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Task
{
    internal class TrustAccount:Account
    {
        public double InterestRate { get; set; }
        private int count = 3;
        private int currentYear;
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
            double threashold = Balance * 20 / 100;
            if(amount < threashold && count>0)
            {
                if (count == 3)
                {
                    currentYear = DateTime.Now.Year;
                    base.Withdraw(amount);
                    count--;
                    return true;
                }
                else
                {
                    if(currentYear != DateTime.Now.Year)
                    {
                        currentYear = DateTime.Now.Year;
                        count = 3;
                        
                    }
                    if(currentYear == DateTime.Now.Year)
                    {
                        base.Withdraw(amount);
                        count--;
                    }
                     return true;
                }

            }
            else
                return false;

        }


    }
}
