namespace FileManager;

public class FileHandler
{
    private readonly string _filePath;

    public FileHandler(string filePath)
    {
        _filePath = filePath;
    }

    public void DisplayFileContent()
    {
        if (File.Exists(_filePath))
        {
            Console.WriteLine($"Zawartość pliku: {_filePath}");
            string content = File.ReadAllText(_filePath);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine($"Plik nie istnieje: {_filePath}");
        }
    }
}
