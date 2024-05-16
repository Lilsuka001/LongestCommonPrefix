
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
            int absN = Math.Abs(n);
            int[] template = new int[absN + 1];
            for (int i = 0; i < template.Length; i++)
            {

                int sumI = i * (i + 1) / 2;
                if (n < 0)
                {
                    sumI = -sumI;
                }
                template[i] = sumI;
            }

            Console.WriteLine(string.Join(", ", template));
            return template;
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