using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\ekimt\text.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Проверь название файла");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Проверь местонахождение файла");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing applications now..");
            }
            Console.ReadLine();


        }
    }
}
