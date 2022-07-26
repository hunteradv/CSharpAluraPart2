using System;

namespace _02_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acc = new CheckingAccount();

            acc.Holder = "Gabriel";

            Console.WriteLine(acc.Holder);
            Console.WriteLine(acc.Agency);
            Console.WriteLine(acc.Number);
            Console.WriteLine(acc.Balance);

            Console.ReadLine();
        }
    }
}
