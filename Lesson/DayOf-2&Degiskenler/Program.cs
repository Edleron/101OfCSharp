#region NOTES
#region Değişken Nedir ?

// Bir değişken, bir değeri saklamak veya kullanmak için kullanılan bir isimlendirilmiş bellek alanıdır. Bu bellek alanı, veri türüne ve değerine göre ayarlanır.

#endregion
#region Değişken Tanımlama

// veri_türü değişken_adı; -> int number;

#endregion
#region Değişkene Değer Atama

// Bir değişkeni tanımladıktan sonra, ona bir değer atayabilirsiniz: -> int sayi = 42;

#endregion
#region Veri Türleri

// C#, çeşitli veri türlerini destekler. İşte bazı örnekler:

// int: Tam sayıları saklamak için kullanılır.
// double: Ondalık sayıları saklamak için kullanılır.
// string: Metin dizilerini saklamak için kullanılır.
//bool: Mantıksal değerleri (true veya false) saklamak için kullanılır.

#endregion
#region Değişken Tür Dönüşümleri

// Veri türleri arasında dönüşüm yapabilirsiniz. Örneğin, bir double değeri bir int değerine dönüştürebilirsiniz:

#endregion
#region Sabitleme

// Sabit değişkenler, değeri programın çalışma süresi boyunca değişmeyen değişkenlerdir. Bir sabit değişkeni tanımlarken, başlangıçta bir değer atamanız gerekmektedir:

#endregion
#endregion

using System;

namespace DayOf_2_Degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Değişken tanımlama ve değer atama
            int yas = 30;
            double not = 85.5;
            string isim = "Ahmet";
            bool aktif = true;

            // 2. Değişken tür dönüşümü (casting)
            double ondalikSayi = 42.75;
            int tamSayi = (int)ondalikSayi;

            // 3. Sabit (const) değişken tanımlama
            const double piSayisi = 3.14159;

            // 4. Değişkenleri kullanma ve ekrana yazdırma
            Console.WriteLine("Adı: " + isim);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Not: " + not);
            Console.WriteLine("Aktif mi? " + aktif);
            Console.WriteLine("Tam Sayı: " + tamSayi);
            Console.WriteLine("Ondalık Sayı: " + ondalikSayi);
            Console.WriteLine("Pi Sayısı: " + piSayisi);

            // 5. Kullanıcıdan girdi alma ve değişkene atama
            Console.Write("Lütfen bir sayı girin: ");
            string girilenMetin = Console.ReadLine();
            int girilenSayi = int.Parse(girilenMetin);
            Console.WriteLine("Girilen Sayı: " + girilenSayi);
        }
    }
}