using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrape myScrape = new Scrape(); //references from MyCodeLibrary
            string value = myScrape.ScrapeWebPage("https://ois2.ttu.ee/uusois/uus_ois2.tud_leht");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
