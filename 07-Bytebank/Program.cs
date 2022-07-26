using System;

namespace _07_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando conta...");
            CheckingAccount acc = new CheckingAccount(867, 867423);

            Console.WriteLine("Total de contas criadas: " + CheckingAccount.TotalAccountsCreated);

            Console.WriteLine("Numero: " + acc.Number);
            Console.WriteLine("Agência: " + acc.Agency);

            Console.WriteLine("Criando conta...");
            CheckingAccount acc2 = new CheckingAccount(867, 867351);

            Console.WriteLine("Total de contas criadas: " + CheckingAccount.TotalAccountsCreated);

            Console.ReadLine();
        }
    }
}
