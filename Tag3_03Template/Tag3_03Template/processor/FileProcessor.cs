using System.Diagnostics;

namespace Tag3_03Template.processor;

public  class FileProcessor
{
    
    private List<FileHandler> fileHandlers = new List<FileHandler>();


    public FileProcessor AddFileHandler(FileHandler fileHandler)
    {
        fileHandlers.Add(fileHandler);
        return this;
    }
    
    public void RemoveFileHandler(FileHandler fileHandler)
    {
        fileHandlers.Remove(fileHandler);
    }

    public void Run(string filename)
    {
        using (var reader = new StreamReader(filename))
        {
            Init();
            int zeichen;

            while ((zeichen = reader.Read()) != -1)
            {
               Process((char)zeichen);
            }

            Dispose();

        }
    }

    private void Init()
    {
        foreach (var handler in fileHandlers)
        {
            handler.Init();
        }
    }

    private void Process(char c)
    {
        foreach (var handler in fileHandlers)
        {
            handler.Process(c);
        }
    }
    private  void Dispose()
    {
        foreach (var handler in fileHandlers)
        {
            handler.Dispose();
        }
    }
}