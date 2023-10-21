using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public class Focus : ICar
    {
        public COLOR StandartColor()
        {
            return COLOR.White;
        }

        public int WhellCount()
        {
            return 4;
        }

        public BRAND WhichBrand()
        {
            return BRAND.Ford;
        }
    }
}