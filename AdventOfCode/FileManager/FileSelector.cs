
namespace FileManager;

public class FileSelector
{
    public string ReadAllText(string filePath)
    {
        if (File.Exists(filePath))
            return File.ReadAllText(filePath);
        else
            throw new FileNotFoundException("File does not exist.");
    }

    public string[] ReadAllLines(string filePath)
    {
        if (File.Exists(filePath))
            return File.ReadAllLines(filePath);
        else
            throw new FileNotFoundException("File does not exist.");
    }

    public string[] ListTxtFilesInFolder(string folderPath)
    {
        if (Directory.Exists(folderPath))
            return Directory.GetFiles(folderPath, "*.txt");
        else
            throw new DirectoryNotFoundException("Folder does not exist.");
    }
}
