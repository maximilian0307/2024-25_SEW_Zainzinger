namespace Bauprojekt;

public interface IProjectElementFactory<T> where T : IProjectComponent
{
    T Create(string name);

}