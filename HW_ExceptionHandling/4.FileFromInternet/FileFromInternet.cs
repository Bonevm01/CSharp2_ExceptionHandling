//4.Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it 
//  the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free 
//  any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Internet
{
    class FileFromInternet
    {
        static void Main()
        {
            Console.WriteLine("The following program is going to download Logo-BASD.jpg to D:\\");
            //Console.Write("Please enter the address in the internet including the exact file name: ");
            string input = "http://www.devbg.org/img/Logo-BASD.jpg";//You coud try with Console.WriteLine() and to see exceptions messages.
            
            WebClient myFile = new WebClient();
            try
            {
                myFile.DownloadFile(input, @"D:\logo.jpg");
                Console.WriteLine("The file was downloaded. Check D:\\logo.jpg");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The internet address was not valid.");
            }

            catch (Exception ex)
            {

                Console.WriteLine("There was a problem while downloding the file to your computer.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myFile.Dispose();
            }

        }

    }
}
