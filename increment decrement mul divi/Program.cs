using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_decrement_mul_divi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int p = (a % 4);
            int b = p++;
            int c = --b;
            int d = (--a * 2);
            Console.WriteLine(a);
            Console.WriteLine(b);   
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
