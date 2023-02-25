using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Inkrement und Dekrement. Postfix und Präfix
 */

namespace myLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;

            a = ++a * a;
            b = b++ * b;                    
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
