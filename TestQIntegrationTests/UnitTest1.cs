using System;
using TestClassLibraryQ;
using Xunit;

namespace TestQIntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MedicineService ms = new MedicineService();
            bool value = ms.ReturnFalse();


            Assert.False(value);
        }

        [Fact]
        public void Test2()
        {
            MedicineService ms = new MedicineService();
            bool value = ms.ReturnFalse2();


            Assert.False(value);
        }
    }
}
