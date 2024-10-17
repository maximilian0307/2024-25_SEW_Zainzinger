namespace Bauprojekt;

public class ProjectManager: IObserver
{
    private List<string> _notifications = new List<string>();

    public void Update(string message)
    {
        _notifications.Add($"Project Manager notified: {message}");
    }

    public string GetNotifications()
    {
        return string.Join("\n", _notifications);
    }
}