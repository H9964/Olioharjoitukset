using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("123456-1324", "Pekka", "Pouta", 39, 325, 2135));
            persons.Add(new Person("651546-1324", "Lauri", "Pouta", 22, 325, 2135));
            persons.Add(new Person("725816-1324", "Kalle", "Pouta", 87, 325, 2135));
            persons.Add(new Person("576257-1324", "Veikko", "Pouta", 46, 325, 2135));
            persons.Add(new Person("248725-1324", "Keke", "Pouta", 74, 325, 2135));
            persons.Add(new Person("983563-1324", "Tero", "Pouta", 24, 325, 2135));
            persons.Add(new Person("834135-1324", "Pate", "Pouta", 83, 325, 2135));
            persons.Add(new Person("654321-1324", "Reiska", "Pouta", 39, 325, 2135));
            /*
            foreach (Person somebody in person)
            {
                Console.Write(somebody.ToString());
            }
            */
            persons.Sort((x, y) => x.Age.CompareTo(y.Age));
            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }

            //try to find person...

            string SSN = "983563-1324";

            Person found = persons.Find(x => x.SSN == SSN);
            if (found != null)
                {
                Console.WriteLine("Person FOUND!");
                }
            else
            {
                Console.WriteLine("Person not found");
            }

            for (int i = 0; i<persons.Count; i++)
            {
                if (persons[i].Age == 88)
                {
                    persons.RemoveAt(i);
                    break;
                }
            }
            /*
            foreach (Person somebody in persons)
            {
                if (somebody.SSN == SSN)
                {
                    Console.WriteLine("Person with SSN " + SSN + "FOUND!");
                    break;
                }
            }
            */

            Console.ReadLine();

        }
    }
}
