using System;
using System.IO;
using System.Text;

namespace ConsoleApptoReplaceStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string filelocation = @"C:\temp\testfilereplace";
            string[] files = Directory.GetFiles(filelocation);
            Console.WriteLine("\n Enter the input string you want to replace: ");
            String inputText = Console.ReadLine();
            Console.WriteLine("\n Enter the Strig you want to replace: ");
            String replaceString = Console.ReadLine();

            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(inputText, replaceString);

                    File.SetAttributes(file, FileAttributes.Normal);
                    
                    File.WriteAllText(file, contents);
                }

                catch(Exception e)
                {
                    Console.WriteLine("\n Something went wrong");
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("\n Replace strings process has been completed successfully ");
            Console.ReadKey();
        }
    }
}
