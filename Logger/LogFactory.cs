﻿using System.Security.AccessControl;

namespace Logger
{
    public class LogFactory
    {
        private string? _Path;
        public BaseLogger CreateLogger(string className)
        {
            if (_Path == null)
            {
                return null!;
            }
            BaseLogger logger = new FileLogger(_Path) { ClassName= className }; //Object initializer for ClassName
            return logger;
        }
        public void ConfigureFileLogger(string path)
        {
            this._Path = path;
        }

    }
}
