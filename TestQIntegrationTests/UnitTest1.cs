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
            bool value = ms.ReturnTrue();

            Assert.True(value);
        }
    }
}
