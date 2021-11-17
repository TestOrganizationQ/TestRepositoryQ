using System;
using TestClassLibraryQ;
using Xunit;

namespace TestQTests.Unit
{
    public class MedicineTests
    {
        [Fact, Trait("Category", "Unit")]
        public void Even_number_passing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.GetEvenMedicine(1004);

            Assert.True(number % 2 == 0);
        }

        [Fact, Trait("Category", "Unit")]
        public void Even_number_failing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.GetEvenMedicine(5);

            Assert.False(number % 2 == 0);
        }

        [Fact]
        public void Odd_number_passing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.GetOddMedicine(1003);

            Assert.True(number % 2 != 0);
        }

        [Fact]
        public void Odd_number_failing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.GetOddMedicine(6);

            Assert.False(number % 2 != 0);
        }
    }
}
