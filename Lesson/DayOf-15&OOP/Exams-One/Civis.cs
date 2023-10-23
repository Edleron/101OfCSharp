using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public class Civis : ICar
    {
        public COLOR StandartColor()
        {
            return COLOR.Gray;
        }

        public int WhellCount()
        {
            return 4;
        }

        public BRAND WhichBrand()
        {
            return BRAND.Honda;
        }
    }
}