using System;
using TestClassLibraryQ;
using Xunit;

namespace TestQTests
{
    public class MedicineTests
    {
        [Fact]
        public void Even_number_passing_test()
        {
            MedicineService medicineService = new MedicineService();
            int number = medicineService.DummyEvenNumber();

            Assert.True(number % 2 == 0);
        }


    }
}
