using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaldinDA.Sprint.Task6.V0.Lib;

namespace Tyuiu.ShaldinDA.Sprint.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5, };
            
            Console.WriteLine("Сумма элементов массива = " + DataServise.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива = " + DataServise.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataServise.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
