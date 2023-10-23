using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Exams
{
    public abstract class Car
    {
        public int WhellCount() {
            return 4;
        }
        public virtual BRAND WhichBrand(){
            return BRAND.Toyota;
        }
        public virtual COLOR StandartColor(){
            return COLOR.White;
        }
    }
}