using System;
using System.IO;

namespace AbstractClass.Abstractions
{
    public abstract class Shape
    {
        protected abstract string[] Lines { get; }

        public void DrawToTerminal()
        {
            foreach (var line in this.Lines)
            {
                Console.WriteLine(line);
            }
        }

        public void DrawToFile(string txtFilePath)
        {
            var fileInfo = new FileInfo(txtFilePath);
            if (fileInfo.Extension != ".txt")
            {
                throw new InvalidOperationException($"File path provided for {GetType().Name} is not a '.txt' file");
            }
            using StreamWriter file = new(txtFilePath);
            foreach (var line in Lines)
            {
                file.WriteLine(line);
            }
        }
    }
}