using System;

namespace Strategy_Adapter_Decorator
{
    public class RubberDuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Rubber Duck squeaks: Squeak Squeak.");
        }
    }
}