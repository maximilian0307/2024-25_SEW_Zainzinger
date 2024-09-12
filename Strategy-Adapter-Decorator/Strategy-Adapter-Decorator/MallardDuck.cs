using System;
using System.Runtime.InteropServices;

namespace Strategy_Adapter_Decorator
{
    public class MallardDuck : IFlyBehavior, IQuackBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Mallard Duck is flying.");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Duck quacks: Quack Quack.");
        }
    }

}