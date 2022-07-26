using System;

namespace _03_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acc = new CheckingAccount();
            acc.Holder = "Marcos";
            acc.Agency = 863;
            acc.Number = 863452;

            CheckingAccount acc2 = new CheckingAccount();
            acc2.Holder = "Marcos";
            acc2.Agency = 863;
            acc2.Number = 863452;

            Console.WriteLine(acc == acc2);

            int age = 27;
            int ageOneMoreTime = 27;

            Console.WriteLine("Igualdade de tipo de valor = " + (age == ageOneMoreTime));

            acc = acc2;
            Console.WriteLine(acc == acc2);

            acc.Balance = 300;
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadLine();
        }
    }
}
