using System;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            BankAccount myAccount = new (7899.21);
            Console.WriteLine($"Номер счета {myAccount.GetNumber()}, " +
                $"Баланс {myAccount.GetBalance()}, " +
                $"тип счета {myAccount.GetChek()}");
            BankAccount myAccount2 = new(536.87, Chek.current);
            Console.WriteLine($"Номер счета {myAccount2.GetNumber()}, " +
                $"Баланс {myAccount2.GetBalance()}, " +
                $"тип счета {myAccount2.GetChek()}");
        }
    } 
}
