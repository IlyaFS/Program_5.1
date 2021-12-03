using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[7];
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                n[i] = Convert.ToDouble(Console.ReadLine());
                sum += n[i];
            }
            int x = 0;
            double result = sum / n.Length;

            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое арифметическое элементов = {0:0.00}", result);
            Console.ReadKey();
        }
    }
}
