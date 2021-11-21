using System;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            BankAccount myAccount = new ();
            myAccount.Balance = 899.79;
            myAccount.Chek = Chek.debit;
            Console.WriteLine($"Номер счета {myAccount.Number}, " +
                $"Баланс {myAccount.Balance}, " +
                $"тип счета {myAccount.Chek}");
            BankAccount myAccount2 = new();
            myAccount2.Balance = 9778.34;
            myAccount2.Chek = Chek.credit;
            Console.WriteLine($"Номер счета {myAccount2.Number}, " +
                $"Баланс {myAccount2.Balance}, " +
                $"тип счета {myAccount2.Chek}");
            myAccount2.GetTransfer(ref myAccount, 500.00); //перводим 500$
            myAccount.Chek = Chek.debit;
            Console.WriteLine($"Номер счета {myAccount.Number}, " +
                $"Баланс {Math.Round(myAccount.Balance, 2)}, " +
                $"тип счета {myAccount.Chek}");
            Console.WriteLine($"Номер счета {myAccount2.Number}, " +
                $"Баланс {myAccount2.Balance}, " +
                $"тип счета {myAccount2.Chek}");
            // Задание 2
            Console.WriteLine("Задание 2 перевернуть строку");
            string str = "hello";
            static string Revers(string str)
            {
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                return new String(arr);
            }
            Console.WriteLine(Revers(str));

        }
    } 
}
