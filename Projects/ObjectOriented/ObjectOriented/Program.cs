using System;

namespace ObjectOriented
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer Angelita = new Customer(1000, 030303, "Angela", "Mrs.");
            Angelita.addMoney(200);
            Console.WriteLine(Angelita.getSavings());
            Angelita.removeMoney(20);
            Console.WriteLine(Angelita.getSavings());
            Console.WriteLine(Angelita.toString());
            Angelita.setName("Phillis");
            Console.WriteLine(Angelita.getName());
            Console.WriteLine(Angelita.toString());
            Console.Read();
        }
    }
}
