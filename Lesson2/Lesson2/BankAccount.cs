using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class BankAccount
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        internal Chek Chek { get; set; }

        private static int nextnumber = 1;
        private static void CreateNumber()
        {
            nextnumber++;
        }
        public BankAccount() 
        {
            this.Number = nextnumber;
            CreateNumber();
        }
        public BankAccount(double money):this() 
        {
            Balance = money;
        }
        public BankAccount(Chek type):this()
        {
            Chek = type; 
        }
        public BankAccount(double money, Chek type) : this()
        {
            Balance = money;
            Chek = type;
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

