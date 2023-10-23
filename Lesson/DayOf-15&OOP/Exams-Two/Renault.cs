using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public class Renault : Car
    {
        public override BRAND WhichBrand()
        {
            return BRAND.Renault;
        }

        public override COLOR StandartColor()
        {
            return base.StandartColor();
        }
    }
}