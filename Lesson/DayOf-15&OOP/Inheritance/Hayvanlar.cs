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