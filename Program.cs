using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            Console.Write("Input a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Input b : ");
            b = double.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine("Result = {0} " +
                "(исходные данные: a = {1} , " +
                "b = {2} )", x,a,b);
            Console.WriteLine($"X = {x}; a = {a}; b = {b}");

        //    float a = 1L;
        //    string str = "Hello \t Worlds";
        //    char symb = 'a';
        //    Console.WriteLine(str);
        //
        }
    }
}
