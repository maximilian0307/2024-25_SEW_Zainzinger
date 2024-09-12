using WindowDecorator;

IWindow window = new SimpleWindow();

IWindow windowWithBlinds = new WindowWithBlinds(window);
IWindow windowWithCurtains = new WindowWithCurtains(windowWithBlinds);
IWindow windowWithTint = new WindowWithTint(windowWithCurtains);

string description = windowWithTint.GetDescription();
double cost = windowWithTint.GetCost();
        
Console.WriteLine(description);
Console.WriteLine("Total cost: $" + cost);