using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibraryQ
{
    public class MedicineService
    {
        public int GetEvenMedicine(int x)
        {
            if(x % 2 == 0)
                return x;
            return 1; 

        }

        public int GetOddMedicine(int x)
        {
            if (x % 2 != 0)
                return x;
            return 2;
        }

        public int GetSomething(int x)
        {
            return x;
        }
    }
}
