using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_25102020
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r = new Rational(3, 6);
            Rational q = new Rational(2, 10);


            Console.WriteLine($"{r}");
            Console.WriteLine(r + q);
            Console.WriteLine(r * q);
        }
    }
}
