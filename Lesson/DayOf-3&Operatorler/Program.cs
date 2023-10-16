#region NOTES

#region Aritmetik Operatörler:

// +: Toplama işlemi için kullanılır.
// -: Çıkarma işlemi için kullanılır.
// *: Çarpma işlemi için kullanılır.
// /: Bölme işlemi için kullanılır.
// %: Mod (bölme işleminden kalan) işlemi için kullanılır.

#endregion

#region Karşılaştırma Operatörleri:

// ==: İki değer birbirine eşitse true döner.
// !=: İki değer birbirine eşit değilse true döner.
// >: Soldaki değer sağdaki değerden büyükse true döner.
// <: Soldaki değer sağdaki değerden küçükse true döner.
// >=: Soldaki değer sağdaki değerden büyük veya eşitse true döner.
// <=: Soldaki değer sağdaki değerden küçük veya eşitse true döner.

#endregion

#region Mantıksal Operatörler:

// && (VE): Her iki ifade de true ise sonuç true olur.
// || (VEYA): Her iki ifadenin en az biri true ise sonuç true olur.
// ! (DEĞİL): Bir ifadeyi ters çevirir, true ise false, false ise true yapar.

#endregion

#region Atama Operatörleri:

// =: Değişkene değer atamak için kullanılır.
// +=, -= gibi: Değişkenin mevcut değerine bir değeri eklemek veya çıkarmak için kullanılır.

#endregion

#endregion

using System;

namespace DayOf_3_Operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Aritmetik Operatörler
            int sayi1 = 10;
            int sayi2 = 5;
            int toplam = sayi1 + sayi2; // toplam şimdi 15 olacak
            int fark = sayi1 - sayi2;   // fark şimdi 5 olacak
            int carpim = sayi1 * sayi2; // carpim şimdi 50 olacak
            int bolum = sayi1 / sayi2;  // bolum şimdi 2 olacak
            int mod = sayi1 % sayi2;    // mod şimdi 0 olacak

            // Karşılaştırma Operatörleri
            bool esitMi = (sayi1 == sayi2); // esitMi şimdi false olacak
            bool kucukMu = (sayi1 < sayi2); // kucukMu şimdi false olacak

            // Mantıksal Operatörler
            bool kosul1 = true;
            bool kosul2 = false;
            bool sonuc1 = (kosul1 && kosul2); // sonuc1 şimdi false olacak
            bool sonuc2 = (kosul1 || kosul2); // sonuc2 şimdi true olacak
            bool sonuc3 = !kosul1;            // sonuc3 şimdi false olacak

            // Atama Operatörleri
            int sayi = 5;
            sayi += 3; // sayi şimdi 8 olacak
            sayi -= 2; // sayi şimdi 6 olacak

            // Ekrana Değişken Değerlerini Yazdırma
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Mod: " + mod);
            Console.WriteLine("Eşit Mi? " + esitMi);
            Console.WriteLine("Küçük Mü? " + kucukMu);
            Console.WriteLine("Sonuç 1: " + sonuc1);
            Console.WriteLine("Sonuç 2: " + sonuc2);
            Console.WriteLine("Sonuç 3: " + sonuc3);
            Console.WriteLine("Sayi: " + sayi);
        }
    }
}