using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitCast
{
    class Program
    {
        static void Main(string[] args)
        {
            long longNumber = 50918309109;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
