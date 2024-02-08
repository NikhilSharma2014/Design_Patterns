using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a design pattern:");
        Console.WriteLine("1. Singleton Pattern");
        Console.WriteLine("2. Factory Method Pattern");
        Console.Write("Enter your choice (1 or 2): ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    UseSingletonPattern();
                    break;
                case 2:
                    UseFactoryMethodPattern();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Exiting.");
        }
    }

    static void UseSingletonPattern()
    {
        SingletonExample singleton = SingletonExample.Instance;
        singleton.DisplayMessage();
    }

    static void UseFactoryMethodPattern()
    {
        FactoryMethodClient factoryMethodClient = new FactoryMethodClient();
        factoryMethodClient.UseFactoryMethodPattern();
    }
}
