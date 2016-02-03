using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace demo6teht4
{
    class Program
    {
        static private Random rand;

        static string RandomString(int length)
        {
            string ret = "";
            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(0, 2);
                if (r == 0)
                {
                    ret += (char)rand.Next('A', 'Z');
                }
                else if (r == 1)
                {
                    ret += (char)rand.Next('a', 'z');
                }
                else if (r == 2)
                {
                    ret += (char)rand.Next('0', '1');
                }
            }
            return ret;
        }

        static void Main(string[] args)
        {
            rand = new Random();

            List<Person> persons = new List<Person>();

            const int personCount = 1000000;

            // start computing elapsed time
            Stopwatch watch = new Stopwatch();
            watch.Start();

            // add persons to list
            for (int i = 0; i < personCount; i++)
            {
                Person p = new Person(RandomString(12),
                                        RandomString(4),
                                        RandomString(8),
                                        rand.Next(1, 100),
                                        rand.Next(30, 140),
                                        rand.Next(100, 220));
                persons.Add(p);
            }

            watch.Stop();
            Console.WriteLine("Adding persons took " + watch.ElapsedMilliseconds + "ms");

            watch.Restart();

            for (int i = 0; i < 1000; i++)
            {
                string nameToFind = RandomString(4);
                Person p = persons.Find(x => x.FirstName == nameToFind);
                if (p != null)
                {
                    //Console.WriteLine("Found person with firstname " + nameToFind + " : " + p.FirstName + " " + p.LastName);
                }
            }

            watch.Stop();
            Console.WriteLine("Finding persons took " + watch.ElapsedMilliseconds + "ms");


            // use dictionary to store persons
            Dictionary<string, Person> persons2 = new Dictionary<string, Person>();

            watch.Restart();
            for (int i = 0; i < personCount; i++)
            {
                do
                {
                    Person p = new Person(RandomString(12),
                                            RandomString(4),
                                            RandomString(8),
                                            rand.Next(1, 100),
                                            rand.Next(30, 140),
                                            rand.Next(100, 220));

                    if (!persons2.ContainsKey(p.FirstName))
                    {
                        persons2.Add(p.FirstName, p);
                        break;
                    }
                } while (true);
            }
            watch.Stop();
            Console.WriteLine("Adding persons to dictionary took " + watch.ElapsedMilliseconds + "ms");


            // find names from the dictionary
            watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                string nameToFind = RandomString(4);
                Person p = null;
                persons2.TryGetValue(nameToFind, out p);
                if (p != null)
                {
                    //Console.WriteLine("Found person with firstname " + nameToFind + " : " + p.FirstName + " " + p.LastName);
                }
            }

            watch.Stop();
            Console.WriteLine(persons2.Count + " persons in dictionary");
            Console.WriteLine("Finding persons from dictionary took " + watch.ElapsedMilliseconds + "ms");



            Console.ReadLine();
        }
    }
}

// https://gist.github.com/janimm/
