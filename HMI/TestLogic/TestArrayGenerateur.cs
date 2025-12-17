using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    public class TestArrayGenerateur
    {
        [Fact]
        public void TestRandomGeneration()
        {
            ArrayGenerator generator = new ArrayGenerator();
            int[] array = generator.GenerateRandomArray(10, 1, 100);
            Assert.Equal(10, array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.InRange(array[i], 1, 100);
            }
        }

    }
}
