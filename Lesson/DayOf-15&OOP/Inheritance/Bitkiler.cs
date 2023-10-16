using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Inheritance
{
    public class Bitkiler : Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar. !");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public void TohumlaCogalma()
        {
            Console.WriteLine("Bitkiler Tohumlu Çoğalır. !");
        }
    }

    public class TohumsuzluBitkiler : Bitkiler
    {
        public void SoparlaCogalma()
        {
            Console.WriteLine("Bitkiler Sporla Çoğalır. !");
        }
    }
}