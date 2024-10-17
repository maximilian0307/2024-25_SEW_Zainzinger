namespace Bauprojekt;

public class MyLogger: ILogger
{ 
    private static MyLogger _instance;
    private List<string> _logMessages = new List<string>();

    private MyLogger() { }

    public static MyLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new MyLogger();
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        _logMessages.Add(message);
    }

    public void WriteLogToFile(string filePath)
    {
        System.IO.File.WriteAllLines(filePath, _logMessages);
        _logMessages.Clear();
    }
}