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
    }
}
