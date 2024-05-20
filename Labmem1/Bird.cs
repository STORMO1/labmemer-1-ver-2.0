using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labmem1
{
    internal class Bird : IPatient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Condition { get; set; }
        public double Weight { get; set; }

    
        public Bird(string name, int age, string gender, string condition, double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Condition = condition;
            Weight = weight;
        }

        public void Diagnose()
        {
            Console.WriteLine($"{Name} (птах) діагностується...");
        }

        public void Treat()
        {
            Console.WriteLine($"{Name} (птах) отримує лікування...");
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} (птах) одужує...");
        }
    }
}