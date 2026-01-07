using LogicLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    public class TestTris
    {
        [Fact]
        public void TestBubbleSort()
        {
            Sorter sorter = new BubbleSort();
            int[] array = new int[] { 5, 3, 8, 4, 2 };
            sorter.Sort(array);
            Assert.Equal(new int[] { 2, 3, 4, 5, 8 }, array);
        }

        [Fact]
        public void TestInsertSort()
        {
            Sorter sorter = new InsertSort();
            int[] array = new int[] { 5, 3, 8, 4, 2 };
            sorter.Sort(array);
            Assert.Equal(new int[] { 2, 3, 4, 5, 8 }, array);
        }

    }
}
