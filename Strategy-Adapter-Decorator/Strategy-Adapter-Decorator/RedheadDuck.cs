using System;

namespace Strategy_Adapter_Decorator
{
    public class RedheadDuck : IFlyBehavior, IQuackBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Redhead Duck is flying.");
        }

        public void Quack()
        {
            Console.WriteLine("Redhead Duck quacks: Quack Quack.");
        }
    }
}