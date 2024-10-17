namespace Bauprojekt;

public class Project
{
    private List<IObserver> _observers = new List<IObserver>();
    private List<IProjectComponent> _components = new List<IProjectComponent>();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }

    public void AddComponent(IProjectComponent component)
    {
        _components.Add(component);
        NotifyObservers($"Component added: {component.Name}");
    }

    public T CreateAndAdd<T>(string name, IProjectElementFactory<T> factory) where T : IProjectComponent
    {
        var component = factory.Create(name);
        AddComponent(component);
        return component;
    }

    public void DisplayProject()
    {
        foreach (var component in _components)
        {
            component.Display(1);
        }
    }
}
 