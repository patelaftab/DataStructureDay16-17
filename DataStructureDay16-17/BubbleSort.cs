using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDay16_17
{
    public class BubbleSort
    {
        public static void Sort()
        {
            int[] array = { 10, 60, 30, 20, 40, 50, 70, 90, 80 };
            int temp = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
