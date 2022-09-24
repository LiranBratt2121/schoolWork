using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(2000, 12, 1);
            Date date1 = new Date(124, 3, 11);
            Date date2 = new Date(2014, 5, 4);
            Console.WriteLine(date.toString());
            Console.WriteLine(date2.toString());
            Console.WriteLine(date1.toString());

        }
    }
}
