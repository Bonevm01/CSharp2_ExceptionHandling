//3.Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents
//  and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//  Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

namespace ReadTextFile
{
    class ReadTextFile
    {
        static string path;
        static void Main()
        {
            Console.WriteLine("Plase enter the file name along with its full file path (e.g. C:\\WINDOWS\\win.ini).");
            Console.Write("Write it here: ");
            path = Console.ReadLine();
            //path = @"D\Misho\Ex.txt";

            try
            {
                string[] fileFormat = path.Split('.');
                string output = File.ReadAllText(path);
                if (fileFormat[fileFormat.Length - 1] != "txt" && fileFormat[fileFormat.Length - 1] != "doc")
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("The selected file contains the following information:");
                Console.WriteLine();
                Console.WriteLine(output);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory was not found");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have access to work with this file.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path is too long.");
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("The selected file was not text type.");
            }
            catch (Exception)
            {
                Console.WriteLine("There is a mistake with your file. Please check again the name and the path you wrote.");
            }


        }

    }
}
