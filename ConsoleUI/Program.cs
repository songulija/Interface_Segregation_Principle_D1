using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //using interface as variable type, not actual implementation
            //interface will only limit you what is in contract
            IBorrowableDVD dvd = new DVD();
            Console.ReadLine();
        }
    }
}
