namespace Logger;

public class LogFactory
{
    public string? FileName { get; set; }

    public BaseLogger? CreateLogger(string logSource) => 
        FileName is null ? null : new FileLogger(logSource, FileName);

    public void ConfigureFileLogger(string fileName) => FileName=fileName;
}
