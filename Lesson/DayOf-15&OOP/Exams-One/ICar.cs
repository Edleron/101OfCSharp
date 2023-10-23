using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public interface ICar
    {
        int WhellCount();

        BRAND WhichBrand();

        COLOR StandartColor();
    }
}