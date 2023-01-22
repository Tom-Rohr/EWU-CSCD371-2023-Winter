using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string? _Path { get; }

        public FileLogger(string path)
        {
            this._Path = path;
            if (File.Exists(path) is false)
            {
                File.Create(path);
            }
        }
        public override void Log(LogLevel logLevel, string message)
        {
            StreamWriter writer = new(File.OpenWrite(_Path!));
            string date = DateTime.Now.ToString();
            string className = nameof(FileLogger);

            if (File.Exists(_Path) is false) return;
            writer.WriteLine($"{date} {className} {logLevel}: {message}");
            writer.Dispose();
        }
    }
}
