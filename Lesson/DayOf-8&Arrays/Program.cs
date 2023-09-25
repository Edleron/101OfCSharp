#region NOTES

#region Array Nedir ?

// Diziler (arrays) birden çok veriyi tek bir değişken altında saklamak ve yönetmek için kullanılır. 

#endregion

#region Array Tanımlama ?

// İnt tipinde bir dizi tanımlama
// int[] sayilar = new int[5]; // 5 elemanlı bir dizi oluşturur

// String tipinde bir dizi tanımlama
// string[] meyveler = new string[] { "Elma", "Armut", "Çilek" };

// Dizi boyutunu belirtmeden dizi tanımlama
// int[] rakamlar = { 1, 2, 3, 4, 5 };

#endregion

#region Array Erişim ?

// Dizi elemanlarına erişmek için indeksleri kullanabilirsiniz. Dizi indeksleri sıfırdan başlar.

#endregion

#region Döngülerle Dizi Kullanımı:

// Döngüler, dizilerle çalışmanın yaygın bir yoludur. Dizilerin içinde bulunan elemanların her birine loop döngüleri ile erişip işlemler yaptırabiliriz.

#endregion

#region Dizi Uzunluğu:

// Diziler, programlarınızda verileri düzenlemek ve işlemek için güçlü bir araçtır. Dizilerin kullanımı, verilerin toplandığı, saklandığı ve işlendiği birçok senaryoda hayati bir öneme sahiptir.
// Bu sebeple içinde birden fazla eleman olacağından, dizinin uzunluğuna lenght ile ulaşabiliriz.

#endregion

#endregion

using System;

namespace DayOf_8_Arrays
{
    class Program
    {
        static void Main()
        {

            #region Konu Özeti
            // Dizi Tanımlama
            int[] sayilar = new int[5]; // 5 elemanlı bir int dizisi oluşturur

            string[] meyveler = new string[] { "Elma", "Armut", "Çilek" }; // String dizisi tanımlama

            int[] rakamlar = { 1, 2, 3, 4, 5 }; // Dizi boyutunu belirtmeden tanımlama

            // Diziye Erişme
            int ilkSayi = sayilar[0]; // İlk eleman
            string ikinciMeyve = meyveler[1]; // İkinci eleman

            // Döngülerle Dizi Kullanımı (for Döngüsü)
            int[] notlar = { 90, 85, 70, 95, 88 };

            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine("Öğrenci " + (i + 1) + " Notu: " + notlar[i]);
            }

            // Döngülerle Dizi Kullanımı (foreach Döngüsü)
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };

            foreach (string gun in gunler)
            {
                Console.WriteLine("Gün: " + gun);
            }

            // Dizi Uzunluğu
            int uzunluk = sayilar.Length; // Dizinin uzunluğu (5)
            #endregion

            #region Array Metods
            // Dizi Tanımlama
            int[] sayilar = { 5, 2, 8, 1, 9 };

            // Dizi Sıralama
            Array.Sort(sayilar); // sayilar dizisini sıralar

            // Dizi Elemanı Arama
            int indeks = Array.BinarySearch(sayilar, 3); // 3 değerini arar ve indeksini döndürür

            // Dizi Kopyalama
            int[] kaynakDizi = { 1, 2, 3, 4, 5 };
            int[] hedefDizi = new int[3];
            Array.Copy(kaynakDizi, hedefDizi, 3); // İlk 3 elemanı kaynak diziden hedef diziye kopyalar

            // Dizi Elemanlarını Temizleme
            int[] temizlenecekDizi = { 1, 2, 3, 4, 5 };
            Array.Clear(temizlenecekDizi, 1, 3); // İndeks 1'den itibaren 3 elemanı sıfırlar

            // Dizi Tersine Çevirme
            int[] tersineDizi = { 1, 2, 3, 4, 5 };
            Array.Reverse(tersineDizi); // tersineDizi dizisini tersine çevirir

            // Dizi Boyutunu Yeniden Boyutlandırma
            int[] eskiDizi = { 1, 2, 3 };
            Array.Resize(ref eskiDizi, 5); // eskiDizi dizisini 5 elemana boyutlandırır

            // Dizi İçindeki Değerin İndeksini Bulma
            int[] indeksDizi = { 1, 2, 3, 4, 3 };
            int ilkIndeks = Array.IndexOf(indeksDizi, 3); // İlk 3 değerinin indeksini döndürür
            int sonIndeks = Array.LastIndexOf(indeksDizi, 3); // Son 3 değerinin indeksini döndürür    
            #endregion

        }
    }
}