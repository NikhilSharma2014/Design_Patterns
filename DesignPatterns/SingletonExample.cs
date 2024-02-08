using System;

public class SingletonExample
{
    private static SingletonExample instance;

    private SingletonExample() { }

    public static SingletonExample Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonExample();
            }
            return instance;
        }
    }

    public void DisplayMessage()
    {
        Console.WriteLine("This is an example of Singleton Pattern.");
    }
}
