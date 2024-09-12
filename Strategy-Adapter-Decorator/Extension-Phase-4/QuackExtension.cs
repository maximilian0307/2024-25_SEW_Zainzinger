using Strategy_Adapter_Decorator;

namespace Extension_Phase_4;

public static class QuackCounterExtension
{
    
    private static Dictionary<IQuackable, int> _quackCounts = new Dictionary<IQuackable, int>();
    
    public static int QuackAndCount(this IQuackable duck)
    {
        duck.Quack();
        
        if (!_quackCounts.ContainsKey(duck))
        {
            _quackCounts[duck] = 0;
        }
        
        _quackCounts[duck]++;
         
        return _quackCounts[duck];
    }
}