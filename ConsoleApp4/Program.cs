using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {long recursivefact = recursivefactorial(10);
            Console.WriteLine(recursivefact);
            long loopfact = loopfactorial(20);
            Console.WriteLine(loopfact);
            BigInteger bigfact = Bigfactorial(30);
            Console.WriteLine(bigfact);
            Console.ReadKey();
        }// مهدی کامرانی نژاد
    }
    }
}
