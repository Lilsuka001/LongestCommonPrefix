
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CSharpLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumOfN(-5);
            SumOfN(7);
        }
        public static int[] SumOfN(int n)
        {

            int[] p = new int[Math.Abs(n) + 1];
            p[0] = 0;
            Console.WriteLine(n);
            for (int i = 1; i <= Math.Abs(n); i++)
                {
                p[i] = p[i - 1] + i * Math.Sign(n);
                }
            Console.WriteLine(string.Join(", ", p));
            return p;
        }
    }
}
/*Последовательность в математике - это последовательность объектов, таких как числа, которые следуют определенному шаблону. 
 * Отдельные элементы последовательности называются терминами. Простой пример - это 3, 6, 9, 12, 15, 18, 21, ..., где шаблон такой: "прибавьте 3 к предыдущему члену".

В этом ката мы будем использовать более сложную последовательность: 0, 1, 3, 6, 10, 15, 21, 28, ... 
Эта последовательность генерируется по шаблону: "n-й член - это сумма чисел от 0 до n включительно".

[0,    1,       3,           6, ...]
 0   0 + 1  0 + 1 + 2  0 + 1 + 2 + 3
*/