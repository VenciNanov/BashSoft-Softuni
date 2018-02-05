using System;

namespace Bashsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            IOManager.CreateDirectoryInCurrentFolder("pesho");

            IOManager.TraverseDirectory(1);
        }
    }
}
