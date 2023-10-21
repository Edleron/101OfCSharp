using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Yapar. !");
        }

        public override void UyaranlaraTepki()
        {
            // gel burada base kodu çalıştır.
            // base.UyaranlaraTepki();
            Console.WriteLine("Hayvalar Temeasa Tepki Verir !");
        }
    }


    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler Sürünerek Hareket Eder !");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public void UcarakHareketETmek()
        {
            Console.WriteLine("Kuşlar Uçarak Hareket Eder !");
        }
    }
}