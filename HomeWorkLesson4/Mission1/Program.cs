using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков

//Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива. 
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[20];
            int i;
            int y = 1; 
            int x = 0;
            Random rnd = new Random();
            

            for (i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10_000, 10_000);
            }
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("....................");
            Console.WriteLine("....................");

            i = 0;

            while (i < a.Length - 1 && y < a.Length)
            {

                if (a[i] % 3 == 0 || a[y] % 3 == 0)
                {
                    Console.WriteLine($"{a[i]} ; {a[y]}");
                    x++;
                }
                y++;
                i++;
            }
            Console.WriteLine("....................");
            Console.WriteLine("....................");
            Console.Write($"Ответ:{x}");
            Console.ReadKey();
        }
    }
}
