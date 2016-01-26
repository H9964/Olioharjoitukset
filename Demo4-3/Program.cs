using System;

namespace Demo4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 4200.50f);
            Boss jussi = new Boss("Jussi Jurkka", "Head of Institute", 9000.0f, "Audi", 5000.0f);

            kirsi.Salary += 1000.0f;
            jussi.Salary -= 2000.0f;
            //jussi.Bonus = 1000.0f;
            //kirsi.Bonus = nocando;

            ShowSomeWork(kirsi);
            ShowSomeWork(jussi);

            Console.ReadLine();
        }
  

        static void ShowSomeWork(Employee empl)
        {
            empl.Work();
        }


        }
    }

