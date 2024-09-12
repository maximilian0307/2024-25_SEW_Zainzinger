using Strategy_Adapter_Decorator;

namespace Strategy_Phase_2;

public class GooseAdapter : IQuackable
{
    private IHonkable _goose;

    public GooseAdapter(IHonkable goose)
    {
        _goose = goose;
    }

    public void Quack()
    {
        Console.WriteLine(_goose.Honk());
    }
}