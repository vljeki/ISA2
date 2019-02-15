using System;
using System.IO;
using System.Net;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            Console.ReadLine();

            string text = "some text";
            File.WriteAllText(@"C:\Users\SomeText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://ained.ttu.ee/course/view.php?id=238");
            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\TextFromWebSite.txt", text);
            Console.ReadLine();
        }
    }
}
