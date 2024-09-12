namespace WindowDecorator;

public abstract class WindowDecorator: IWindow
{
    protected IWindow _window;

    // Konstruktor, der ein IWindow-Objekt erhält
    public WindowDecorator(IWindow window)
    {
        _window = window;
    }

    public abstract string GetDescription();
    public abstract double GetCost();
}