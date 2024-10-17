namespace Bauprojekt;

public interface ILogger
{
    // Methode zum Hinzufügen einer Protokollnachricht
    void Log(string message);

    // Methode zum Schreiben der Protokollnachrichten in eine Datei
    void WriteLogToFile(string filePath);      
}