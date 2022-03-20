using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal class FileLogger : ILogger
    {
        private string filePath;
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer =
                new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }

        public FileLogger(string filePath)
        {
           this.filePath = filePath;    
        }
    }
}
