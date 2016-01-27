using System;
using System.Collections.Generic;

namespace Demo5_1
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void RemoveTyres()
        {
            tyres.Clear();
        }

        public void AddTyre(Tyre t)
        {
            tyres.Add(t);
        }

        public Vehicle (string brand, string model)
        {
            Brand = brand;
            Model = model;

            tyres = new List<Tyre>();

            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17\n"));


        }

        public override string ToString()
        {
            string s = "Vehicle: " + Brand + ", " + Model;

            if (tyres.Count == 0)
            {
                s += "\nNo tyres\n ";
            }
            else
            {
                foreach (Tyre t in tyres)
                {
                    s += "\n";
                    s += t.ToString();
                }
            }
            return s;
        }

        private List<Tyre> tyres;

    }
}
