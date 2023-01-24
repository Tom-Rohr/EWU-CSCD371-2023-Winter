namespace Logger;

public abstract class BaseLogger
{
    public string? ClassName { get; set; } //Auto-property

    public abstract void Log(LogLevel logLevel, string message);
}
