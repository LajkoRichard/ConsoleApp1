using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "valami";
            bool isEqual = string.Equals("valami", str);
            Console.WriteLine(isEqual);
            Console.ReadKey();
        }
    }
}
