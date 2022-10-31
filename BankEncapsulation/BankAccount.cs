//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        //We are using all these methods because we dont have sirect access to balance
        private double balance=0;



        public BankAccount(double amount)
        {
            this.balance = amount;


        }

        public void deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit accepted");
        }
        public double getbalance()
        {
            return balance;

        }


    }
    


}
