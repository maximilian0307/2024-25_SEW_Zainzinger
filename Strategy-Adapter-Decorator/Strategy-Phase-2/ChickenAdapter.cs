using Strategy_Adapter_Decorator;

namespace Strategy_Phase_2;

public class ChickenAdapter: IQuackable
{
    private ICackleable _chicken;

    public ChickenAdapter(ICackleable chicken)
    {
        _chicken = chicken;
    }

    public void Quack()
    {
        Console.WriteLine(_chicken.Cackle());
    }
}