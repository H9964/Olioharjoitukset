using System;

namespace Demo5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Toyota", "Purkki");
            Console.WriteLine(mycar.ToString());

            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());

            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "195/65R15\n"));
            Console.WriteLine(mycar.ToString());

            Console.ReadLine();
        }
    }
}
