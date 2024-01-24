using System;
using System.IO;
    class Program
    {
        
        static readonly string rootFolder = @"C:\Users\gnkra\Downloads";// Default folder
        static void Main(string[] args)
        {
      
        string File_ = "Tasks.txt";  // Files to be deleted
            try
            {
                if (File.Exists(Path.Combine(rootFolder, File_))) // Check if file exists with its full path
                {                
                    File.Delete(Path.Combine(rootFolder, File_));  // If file found, delete it
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }          
        }
    }
