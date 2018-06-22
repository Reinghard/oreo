using System;
using Xunit;


namespace xUnitTest
{
    
    public class UnitTest1
    {
       [Fact]
        public void TestMethod1()
        {   

            int x = 10;
            int y = 20;
            int expected = 30;

            MyCalcLib.MyCalc c = new MyCalcLib.MyCalc();
            int actual = c.Sum(x, y);

            Assert.Equal(expected, actual);

        }
    }
}
