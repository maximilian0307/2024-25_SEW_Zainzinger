using Strategy_Adapter_Decorator;

namespace DuckTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestQuacking()
    {
        
        List<IQuackBehavior> ducks = new List<IQuackBehavior>
        {
            new MallardDuck(),
            new RedheadDuck(),
            new RubberDuck(),
            new PlasticDuck()
            
        };

       
        foreach (var duck in ducks)
        {
            duck.Quack();
        }
    }
}