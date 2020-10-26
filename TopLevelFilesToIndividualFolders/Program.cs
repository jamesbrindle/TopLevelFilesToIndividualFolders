using System;
using System.IO;

namespace TopLevelFilesToIndividualFolders
{
    public class Program
    {
        static void Main()
        {
            foreach (var file in Directory.GetFiles("."))
            {
                if (!file.Contains("TopLevelFilesToIndividualFolders.exe"))
                {
                    Console.WriteLine($"Processing: {file}");

                    Directory.CreateDirectory(Path.GetFileNameWithoutExtension(file));
                    File.Move(file, Path.GetFileNameWithoutExtension(file) + "\\" + Path.GetFileName(file));
                }
            }
        }
    }
}
