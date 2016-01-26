using System;

namespace Demo4_3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public float Bonus { get; set; }

        public Boss(string name, string profession, float salary, string car, float bonus)
            :base(name, profession, salary)
        {
            Car = Car;
            Bonus = Bonus;
        }

        public virtual void Work()
        {
            {
                Console.WriteLine("Working. Did work more previously. No need anymore. Others will work for me");
            }
        }
    }
}
