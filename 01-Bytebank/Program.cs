using System;

namespace _01_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acc1 = new CheckingAccount()
            {
                Holder = "Gabriela",
                Agency = 863,
                Number = 863146,
                Balance = 100
            };

            Console.WriteLine(acc1.Holder);
            Console.WriteLine("Agência: " + acc1.Agency);
            Console.WriteLine("Número: " + acc1.Number);
            Console.WriteLine("Saldo: " + acc1.Balance);

            acc1.Balance += 100;

            Console.WriteLine("Novo saldo: " + acc1.Balance);

            Console.ReadLine();
        }
    }
}
