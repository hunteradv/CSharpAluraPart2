using System;

namespace _05_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client gabriela = new Client()
            //{
            //    Name = "Gabriela",
            //    Profession = "Professora C#",
            //    Cpf = "123.456.789-09"
            //};

            CheckingAccount acc = new CheckingAccount()
            {
                Agency = 456,
                Number = 456390
            };

           //acc.Holder.Name = "Gabriela Marques";

            if (acc.Holder == null)
            {
                Console.WriteLine("Ops, a referencia em acc.Holder é nula");
            }

            //Console.WriteLine(gabriela.Name);
            Console.WriteLine(acc.Holder);

            Console.ReadLine();
        }
    }
}
