using System;

namespace Strategy_Adapter_Decorator
{
    public class PlasticDuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Plastic Duck makes no sound.");
        }
    }
}