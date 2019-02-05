using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков

//а) Дописать класс для работы с одномерным массивом. 
//Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, 
//метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
//В Main продемонстрировать работу класса.

namespace Mission2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

            Console.WriteLine($"Введите размерность массива:"); 
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите начальное значение массива:");
            int start_value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите шаг значений массива:");
            int step = Convert.ToInt32(Console.ReadLine());

            Helper Array1 = new Helper(count,start_value,step);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Array1.MainArray[i]);
            }

            Console.WriteLine($"...................");
            Console.WriteLine($"..Revers...........");
            Console.WriteLine($"...................");

            Helper.Inverse(Array1.MainArray);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Array1.MainArray[i]);
            }

            Console.WriteLine($"...................");
            Console.WriteLine($".......Summa.......");
            Console.WriteLine($"...................");

            int s = Helper.Sum(Array1.MainArray);

            Console.WriteLine(s);

            Console.WriteLine($"...................");
            Console.WriteLine($".......Multi.......");
            Console.WriteLine($"...................");

            int Multi = Helper.Multi(Array1.MainArray);

            Console.WriteLine(Multi);

            Console.WriteLine($"...................");
            Console.WriteLine($".......MaxCount....");
            Console.WriteLine($"...................");

            int MaxValue = Helper.MaxCount(Array1.MainArray);

            Console.WriteLine(MaxValue);

            Console.ReadKey();
        }
    }
}
