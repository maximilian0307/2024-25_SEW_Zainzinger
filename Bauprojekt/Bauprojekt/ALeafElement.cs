namespace Bauprojekt;

public class ALeafElement: IProjectComponent
{
    public string Name { get; private set; }

    public ALeafElement(string name)
    {
        Name = name;
    }

    public void Add(IProjectComponent component)
    {
        throw new InvalidOperationException("Leaf elements cannot have children.");
    }

    public void Remove(IProjectComponent component)
    {
        throw new InvalidOperationException("Leaf elements cannot have children.");
    }

    public virtual void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}