using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Task
{
    internal class SavingsAccount : Account
    {
        public double  InterestRate { get; set; }

        public SavingsAccount()
        {
            
        }
        public SavingsAccount(string name):base(name)
        {
            
        }
        public SavingsAccount(string name,double balance) : base(name, balance)
        {

        }
        public SavingsAccount(string name,double balance,double interestRate) : base(name, balance)
        {
            InterestRate = interestRate;
        }

        public override string ToString()
        {
            return $"Account Name: {Name} , Account Balance: {Balance} , Account Interest Rate: {InterestRate}";
        }


    }
}
