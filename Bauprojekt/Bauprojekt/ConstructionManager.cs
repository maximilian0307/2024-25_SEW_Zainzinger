namespace Bauprojekt;

public class ConstructionManager: IObserver
{
    private List<string> _notifications = new List<string>();

    public void Update(string message)
    {
        _notifications.Add($"Construction Manager notified: {message}");
    }

    public string GetNotifications()
    {
        return string.Join("\n", _notifications);
    }
}