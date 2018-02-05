using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bashsoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            var initialIdentation = SessionData.currentPath.Split('\\').Length;

            Queue<string> subFloders = new Queue<string>();
            subFloders.Enqueue(SessionData.currentPath);

            while (subFloders.Count != 0)
            {
                var currentPath = subFloders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;

                if (depth - identation<0)
                {
                    break;
                }
               
                OutputWriter.WriteMessageOneNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));

                foreach (var file in Directory.GetFiles(currentPath))
                {
                    int indexOfLastSlah = file.LastIndexOf("\\");
                    string fileName = file.Substring(indexOfLastSlah);
                    OutputWriter.WriteMessageOneNewLine(new string('-', indexOfLastSlah) + fileName);
                }

                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    subFloders.Enqueue(directoryPath);
                }
            }
        }
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = GetCurrentDirectoryPath() + "\\" + name;
            Directory.CreateDirectory(path);

        }

        public static string GetCurrentDirectoryPath() => SessionData.currentPath;
        
    }
}
