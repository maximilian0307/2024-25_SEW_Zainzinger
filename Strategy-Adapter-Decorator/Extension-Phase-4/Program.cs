using Extension_Phase_4;
using Strategy_Adapter_Decorator;

internal class Program
{
    public static void Main(string[] args)
    {
        RedheadDuck redHeadDuck = new RedheadDuck();
        MallardDuck mallardDuck = new MallardDuck();


        Console.WriteLine("Redhead Duck Quack Count: " + redHeadDuck.QuackAndCount()); // 1
        Console.WriteLine("Redhead Duck Quack Count: " + redHeadDuck.QuackAndCount()); // 2
        Console.WriteLine("Mallard Duck Quack Count: " + mallardDuck.QuackAndCount()); // 1
        Console.WriteLine("Mallard Duck Quack Count: " + mallardDuck.QuackAndCount()); // 2
        Console.WriteLine("Mallard Duck Quack Count: " + mallardDuck.QuackAndCount()); // 3
    }
}