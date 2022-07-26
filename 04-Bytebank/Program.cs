using System;

namespace _04_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acc = new CheckingAccount();

            acc.Holder = "Bruno";

            Console.WriteLine("Saldo: " + acc.Balance);

            Console.WriteLine("Sacando $50");
            bool withdrawResult = acc.Withdraw(50);
            Console.WriteLine(withdrawResult);

            Console.WriteLine("Saldo: " + acc.Balance);

            Console.WriteLine("Depositando $500.0");
            acc.Deposit(500);

            Console.WriteLine("Saldo: " + acc.Balance);

            Console.WriteLine();
            Console.WriteLine();

            CheckingAccount acc2 = new CheckingAccount();
            acc2.Holder = "Nathan";
            Console.WriteLine("Saldo conta 1: " + acc.Balance);
            Console.WriteLine("Saldo conta 2: " + acc2.Balance);

            Console.WriteLine();
            Console.WriteLine("Transferindo $50 da conta 1 para 2");
            bool transferResult = acc.Transfer(50, acc2);
            Console.WriteLine(transferResult);

            Console.WriteLine();
            Console.WriteLine("Saldo conta 1: " + acc.Balance);
            Console.WriteLine("Saldo conta 2: " + acc2.Balance);

            Console.WriteLine();
            Console.WriteLine("Transferindo $2000 da conta 2 para 1");            
            bool transferResult2 = acc2.Transfer(2000, acc);
            Console.WriteLine("Resultado transferencia: " + transferResult2);

            Console.WriteLine("Saldo conta 1: " + acc.Balance);
            Console.WriteLine("Saldo conta 2: " + acc2.Balance);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
