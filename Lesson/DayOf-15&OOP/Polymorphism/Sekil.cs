using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Polymorphism
{
// Üst Sınıf (Base Class veya Parent Class)
    class GeometrikSekil
    {
        public virtual void Ciz()
        {
            Console.WriteLine("Geometrik şekil çiziliyor.");
        }
    }

    // Alt Sınıf (Derived Class veya Child Class)
    class Daire : GeometrikSekil
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire çiziliyor.");
        }
    }

    class Kare : GeometrikSekil
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare çiziliyor.");
        }
    }
}