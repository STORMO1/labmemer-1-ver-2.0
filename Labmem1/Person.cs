using Labmem1;
using System;

internal class Person : IPatient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Condition { get; set; }
    public double Weight { get; set; }

    
    public Person(string name, int age, string gender, string condition, double weight)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Condition = condition;
        Weight = weight;
    }

    public void Diagnose()
    {
        Console.WriteLine($"{Name} (людина) діагностується...");
    }

    public void Treat()
    {
        Console.WriteLine($"{Name} (людина) отримує лікування...");
    }

    public void Heal()
    {
        Console.WriteLine($"{Name} (людина) одужує...");
    }
}
