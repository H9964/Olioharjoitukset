using System;
using System.Collections.Generic;

namespace demo6teht4
{
    class Person
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string SSN,
                        string firstName,
                        string lastName,
                        int age,
                        int weigth,
                        int height)
        {
            this.SSN = SSN;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weigth;
            Height = height;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName +
                    "\nLast Name: " + LastName +
                    "\nSSN: " + SSN +
                    "\nAge: " + Age +
                    "\nWeight: " + Weight +
                    "\nHeight: " + Height +
                    "\n\n";
        }
    }
}