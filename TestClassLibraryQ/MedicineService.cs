﻿using System;
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
            return 4;
        }

        public bool ReturnTrue()
        {
            return 2 == 2;
        }

        public bool ReturnFalse()
        {
            return 1 == 4;

        }
    }
}
