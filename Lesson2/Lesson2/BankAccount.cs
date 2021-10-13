using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class BankAccount
    {
        private int number;
        private double balance;
        private Chek chek;
        private static int nextnumber = 1;

        private static void CreateNumber()
        {
            nextnumber++;
        }
        public BankAccount() 
        {
            this.number = nextnumber;
            CreateNumber();
        }
        public BankAccount(double money):this() 
        {
            balance = money;
        }
        public BankAccount(Chek type):this()
        {
            chek = type; 
        }
        public BankAccount(double money, Chek type) : this()
        {
            balance = money;
            chek = type;
        }
        public int GetNumber()
        {
            return this.number;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public Chek GetChek()
        {
        return this.chek;
        }
    }
}
    enum Chek
    {
        no,
        debit,
        credit,
        current
    }

