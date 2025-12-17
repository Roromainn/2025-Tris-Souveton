using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ArrayGenerator
    {
        public int[] GenerateRandomArray(int size, int min, int max)
        {
            int [] temp = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                temp[i] = rnd.Next(min, max+1);
            }
            return temp;
        }
    }
}
