using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    public class TestStrategy
    {
        [Fact]
        public void TestRegister()
        {
            SorterStrategy strategy = new SorterStrategy();
            strategy.RegisterSorter("no sort", new NoSort());
            Assert.Contains("no sort", strategy.Names);
        }
        [Fact]
        public void TestChoose()
        {
            SorterStrategy strategy = new SorterStrategy();
            strategy.RegisterSorter("no sort", new NoSort());
            Assert.IsType<NoSort>(strategy.ChooseSorter("no sort"));
        }
    }
}
