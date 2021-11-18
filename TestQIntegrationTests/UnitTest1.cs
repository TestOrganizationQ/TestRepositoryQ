using System;
using TestClassLibraryQ;
using Xunit;

namespace TestQIntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Odd_number_failing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.Return1();

            Assert.True(number == 1);

        }
    }
}
