﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void FileLogger_OnCreation_HasCallingClassName()
        {
            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testLog.txt");

            LogFactory factory = new();
            factory.ConfigureFileLogger(testPath);
            BaseLogger logger = factory.CreateLogger(GetType().Name);

            logger.Log(LogLevel.Information, "this is test message #1");
            logger.Log(LogLevel.Information, "this is test message #2");

            Assert.AreEqual(logger.ClassName, GetType().Name);
        }

    }
}
