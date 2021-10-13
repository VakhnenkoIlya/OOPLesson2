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
        public int GetNumber()
        {
            return this.number;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public double GetBalance()
        {
            return this.balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    
        public Chek GetChek()
        {
        return this.chek;
        }

        public void SetChek(Chek chek)
        {
        this.chek = chek;

        }
    }
}
    enum Chek
    {
        debit,
        credit,
        current
    }

