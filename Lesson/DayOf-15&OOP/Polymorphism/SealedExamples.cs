using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP.Polymorphism
{
// Sealed Sınıf
    sealed class Muhendislik
    {
        public void BilgiPaylasimi()
        {
            Console.WriteLine("Mühendislik bilgi paylaşımı yapılıyor.");
        }
    }

    // Hata! Bu satır hata verecektir, çünkü Muhendislik sınıfı sealed ve miras alınamaz.
    // class InsaatMuhendisi : Muhendislik
    // {
        // ...
    // }
}