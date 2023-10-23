using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public class Porshe : Car
    {
        public override COLOR StandartColor()
        {
            return COLOR.Gray;
        }

        public override BRAND WhichBrand()
        {
            return BRAND.Porche;
        }
    }   
}