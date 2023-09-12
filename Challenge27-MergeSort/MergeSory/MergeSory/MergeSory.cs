using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSory
{
    public class MergeSort
    {
        public void MergeSorts(int[] array)
        {
            int n = array.Length;
            if (n>1)
            {
                var mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }
                for (int i = mid; i < n; i++)
                {
                    right[i -mid] = array[i];
                }
                MergeSorts(left);
                MergeSorts(right);
                Merge(left, right,array);
            }
        }
        public void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k =0;
            while(i< left.Length && j< right.Length)
            {
                if (left[i] <= right[j]) 
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j ++;
                }
                k++;
            }
            while(i < left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while(j < right.Length)
            {
                array[k] = right[j];
                j ++;
                k++;
            }
        }
    }
}
