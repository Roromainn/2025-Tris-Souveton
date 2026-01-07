using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicLayer
{
    public class QuickSort : Sorter
    {
        public string Name { get; } = "Tri rapide";
        public void Sort(int[] values)
        {
            DoQuickSort(values, 0, values.Length - 1);
        }

        private void DoQuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                DoQuickSort(array, low, pi - 1);

                DoQuickSort(array, pi + 1, high);
            }
        }
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
         }
    }
}

