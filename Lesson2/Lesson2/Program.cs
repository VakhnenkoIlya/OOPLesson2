using System;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            BankAccount myAccount = new ();
            myAccount.SetNumber(1);
            myAccount.SetBalance(7899.99);
            myAccount.SetChek(0);
            Console.WriteLine($"Номер счета {myAccount.GetNumber()}, " +
                $"Баланс {myAccount.GetBalance()}, " +
                $"тип счета {myAccount.GetChek()}");
            BankAccount myAccount2 = new();
            myAccount2.SetBalance(350.90);
            myAccount2.SetChek(Chek.current);
            Console.WriteLine($"Номер счета {myAccount2.GetNumber()}, " +
                $"Баланс {myAccount2.GetBalance()}, " +
                $"тип счета {myAccount2.GetChek()}");
        }
    } 
}
