namespace Bauprojekt;

public class ACompositeElement: IProjectComponent
{
    protected List<IProjectComponent> _children = new List<IProjectComponent>();
    public string Name { get; private set; }

    public ACompositeElement(string name)
    {
        Name = name;
    }

    public void Add(IProjectComponent component)
    {
        _children.Add(component);
        MyLogger.Instance.Log($"Added {component.Name} to {Name}");
    }

    public void Remove(IProjectComponent component)
    {
        _children.Remove(component);
        MyLogger.Instance.Log($"Removed {component.Name} from {Name}");
    }

    public virtual void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }
}