using Bauprojekt;
public static class Program
{
    public static void Main(string[] args)
    {
        Project project = new Project();
        ProjectManager projectManager = new ProjectManager();
        ConstructionManager constructionManager = new ConstructionManager();
        
        project.RegisterObserver(projectManager);
        project.RegisterObserver(constructionManager);

        Building building = project.CreateAndAdd("Main Building", new BuildingFactory());
        Garden garden = project.CreateAndAdd("Beautiful Garden", new GardenFactory());

        Room room1 = new Room("Conference Room");
        Room room2 = new Room("Office Room");
        building.Add(room1);
        building.Add(room2);

        Material material1 = new Material("Steel");
        room1.Add(material1);

        MyLogger.Instance.WriteLogToFile("project.log.txt");
        
        building.Display(1);
        garden.Display(1);
    }
}