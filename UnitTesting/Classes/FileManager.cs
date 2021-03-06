using System;
using System.IO;

namespace Classes
{
    public class FileManager
    {
        public bool IsFileExist(string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                throw new ArgumentException("file");
            }

            return File.Exists(file);
        }
    }
}
