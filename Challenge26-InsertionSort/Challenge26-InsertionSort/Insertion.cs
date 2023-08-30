using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge26_InsertionSort
{
    public class Insertion
    {
        public int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }

            return array;
        }
    }
}
