using Labmem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Ввести дані кого?");
        Console.WriteLine("1. Людини");
        Console.WriteLine("2. Собаки");
        Console.WriteLine("3. Птаха");

        int choice = int.Parse(Console.ReadLine());
        IPatient patient = null;

        Console.Write("Введіть ім'я:");
        string name = Console.ReadLine();

        Console.Write("Введіть вік:");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введіть стать:");
        string gender = Console.ReadLine();

        Console.Write("Введіть дефект або захворювання:");
        string condition = Console.ReadLine();

        Console.Write("Введіть вагу (кг):");
        double weight = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                patient = new Person(name, age, gender, condition, weight);
                break;
            case 2:
                patient = new Dog(name, age, gender, condition, weight);
                break;
            case 3:
                patient = new Bird(name, age, gender, condition, weight);
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                return;
        }

        patient.Diagnose();
        Thread.Sleep(2000);
        patient.Treat();
        Thread.Sleep(2000);
        patient.Heal();

        Console.ReadLine(); 
    }
}
