using Strategy_Adapter_Decorator;

namespace Counter_Phase_2;

public class QuackCounter : IQuackable, IQuackCounter
{
    private IQuackable _duck;
    private static int _quackCount = 0;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    public void Quack()
    {
        _duck.Quack();
        _quackCount++;
    }

    public int GetQuackCount()
    {
        return _quackCount;
    }

    // Reset the counter if needed
    public static void ResetCounter()
    {
        _quackCount = 0;
    }
}