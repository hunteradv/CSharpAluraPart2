using System;

namespace _06_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acc = new CheckingAccount();
            Client client = new Client();

            client.Name = "Guilherme";
            client.Cpf = "493.231.393-20";
            client.Profession = "Desenvolvedor c#";

            acc.Balance = -10;
            acc.Holder = client;

            Console.WriteLine(acc.Holder.Name);
            Console.WriteLine(acc.Balance);

            Console.ReadLine();
        }
    }
}
