namespace Bauprojekt;

public class GardenFactory : IProjectElementFactory<Garden>
{
    public Garden Create(string name)
    {
        return new Garden(name);
    }
}