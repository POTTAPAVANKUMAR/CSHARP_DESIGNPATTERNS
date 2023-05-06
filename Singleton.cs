using System;
public class Singleton
{
    private static Singleton instance;
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Singleton instance1 = Singleton.Instance;
        Singleton instance2 = Singleton.Instance;
        Console.WriteLine(instance1 == instance2); 
        string a = Console.ReadLine(); 
        Console.WriteLine(a);
    }
}

