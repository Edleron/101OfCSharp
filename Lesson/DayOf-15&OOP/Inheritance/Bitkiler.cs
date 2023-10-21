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

        public override void UyaranlaraTepki()
        {
            // gel burada base kodu çalıştır.
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler Güneşe Tepki Verir. !");
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

    public class Kuslar: Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void Ucmak(){
            Console.WriteLine("Kuşlar Uçar. !");
        }
    }
}