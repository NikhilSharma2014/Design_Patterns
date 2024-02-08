using System;

public class FactoryMethodClient
{
    public void UseFactoryMethodPattern()
    {
        Console.WriteLine("Choose a product type:");
        Console.WriteLine("1. Product of Type A");
        Console.WriteLine("2. Product of Type B");
        Console.Write("Enter your choice (1 or 2): ");

        if (int.TryParse(Console.ReadLine(), out int productChoice))
        {
            ICreator creator;

            switch (productChoice)
            {
                case 1:
                    creator = new ConcreteCreatorA();
                    break;
                case 2:
                    creator = new ConcreteCreatorB();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    return;
            }

            IProduct product = creator.FactoryMethod();
            product.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Invalid input. Exiting.");
        }
    }
}
