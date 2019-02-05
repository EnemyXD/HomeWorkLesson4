using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Helper
    {
        public int[] MainArray;

        public Helper(int count, int start_value, int step)
        {
            MainArray= new int[count];
            MainArray[0] = start_value;
            int i;
            for (i = 1; i < count; i++)
            {
                MainArray[i] = start_value + step;
                start_value += step;
            }

            

        }

        public static int Sum(int[] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum = sum + mass[i];
            }  

            return sum;
        }

        /// <summary>
        /// программа, изменяющая порядок элеметов в массиве
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        public static Array Inverse(Array mass)
        {

            Array.Reverse(mass);

            return mass;
        }

        public static int Multi(int[] mass)
        {
            int Multi = 1;
            for (int i = 0; i < mass.Length; i++)
            {
                Multi = Multi * mass[i];
            }

            return Multi;
        }

        public static int MaxCount(int[] mass)
        {

            int maxValue = mass.Max();


            return maxValue;
        }
    }
}
