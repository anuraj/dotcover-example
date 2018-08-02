using System;
using Xunit;

namespace helloxunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);
        }
    }
}
