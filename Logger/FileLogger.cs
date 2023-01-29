using System;
using System.IO;

namespace Logger;

public class FileLogger : BaseLogger
{
    private string? _Path { get; }

    public FileLogger(string path)
    {
        this._Path = path;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        StreamWriter writer = File.AppendText(_Path!);
        string dateAndTime = DateTime.Now.ToString();
        writer.WriteLine($"{dateAndTime} {ClassName} {logLevel}: {message}");
        writer.Dispose();
    }
}