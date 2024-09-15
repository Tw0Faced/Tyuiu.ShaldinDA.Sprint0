using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShaldinDA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShaldinDA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataServise.Addition(1, 5));
            Console.WriteLine("A - B = " + DataServise.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataServise.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataServise.Division(5, 0));
            Console.ReadKey();
        }
    }
}
