namespace Bauprojekt;

public interface IProjectComponent
{
    string Name { get; }
    void Display(int depth);
    void Add(IProjectComponent component);
    void Remove(IProjectComponent component);
}