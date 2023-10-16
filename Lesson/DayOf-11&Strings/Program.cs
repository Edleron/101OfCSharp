using System;

namespace DayOf_11_Strings
{

    class Program
    {
        static void Main(string[] args)
        {
            #region STRINGS METODS
            // Length Özelliği: Bir dizenin karakter sayısını döndürür
            string kelime = "Merhaba";
            int uzunluk = kelime.Length; // uzunluk, 7 olacaktır
            Console.WriteLine(uzunluk);

            // ToUpper() ve ToLower() Metodları: Dizeyi büyük veya küçük harfe dönüştürür
            string buyukHarfli = kelime.ToUpper(); // "MERHABA"
            string kucukHarfli = kelime.ToLower(); // "merhaba"
            Console.WriteLine(buyukHarfli);
            Console.WriteLine(kucukHarfli);

            // Substring Metodları: Dizeden belirli bir kısmı alır
            string ornek = "Bu bir örnek metindir.";
            string altMetin1 = ornek.Substring(3); // "bir örnek metindir."
            string altMetin2 = ornek.Substring(3, 7); // "bir örne"
            Console.WriteLine(altMetin1);
            Console.WriteLine(altMetin2);

            // IndexOf ve LastIndexOf Metodları: Belirli bir değerin indeksini bulur
            string metinX = "Bu bir örnek metin.";
            int ilkIndex = metinX.IndexOf("bir"); // İlk "bir" kelimesinin indeksi (3)
            int sonIndex = metinX.LastIndexOf("bir"); // Son "bir" kelimesinin indeksi (16)
            Console.WriteLine(ilkIndex);
            Console.WriteLine(sonIndex);

            // Replace Metodu: Dize içinde bir değeri başka bir değerle değiştirir
            string orijinalMetin = "Bu bir örnek metindir.";
            string yeniMetin = orijinalMetin.Replace("örnek", "çalışma"); // "Bu bir çalışma metindir."
            Console.WriteLine(yeniMetin);

            // Trim Metodu: Dizenin başındaki ve sonundaki boşlukları kaldırır
            string metinY = "   Bu bir örnek metindir.   ";
            string temizMetin = metinY.Trim(); // "Bu bir örnek metindir."
            Console.WriteLine(temizMetin);

            // Split Metodu: Dizeyi ayırıcı karakterlere göre böler
            string liste = "elma,armut,çilek,karpuz";
            string[] meyveler = liste.Split(','); // ["elma", "armut", "çilek", "karpuz"]
            Console.WriteLine(meyveler);
            #endregion

            #region DATETIME METODS
            // DateTime Nesnesi Oluşturma
            DateTime simdikiZaman = DateTime.Now; // Geçerli tarih ve saat bilgisini alır
            DateTime belirliTarih = new DateTime(2023, 9, 30); // Belirli bir tarih oluşturur (Yıl, Ay, Gün)

            // Temel Özellikler
            DateTime bugun = DateTime.Today; // Geçerli tarihi döndürür (saat bilgisini ihmal eder)
            DateTime tarihSaat = DateTime.Now; // Geçerli tarih ve saat bilgisini döndürür

            // Tarih ve Saat Bilgilerini Almak
            int yil = simdikiZaman.Year; // Yılı alır
            int ay = simdikiZaman.Month; // Ayı alır
            int gun = simdikiZaman.Day; // Günü alır
            int saat = simdikiZaman.Hour; // Saati alır
            int dakika = simdikiZaman.Minute; // Dakikayı alır
            int saniye = simdikiZaman.Second; // Saniyeyi alır

            // Tarih ve Saat İşlemleri
            DateTime gelecekTarih = simdikiZaman.AddDays(7); // 7 gün sonrasını hesaplar
            TimeSpan fark = gelecekTarih - simdikiZaman; // İki tarih arasındaki farkı hesaplar

            // Tarih ve Saat Biçimlendirme
            string tarihMetni = simdikiZaman.ToString("dd.MM.yyyy HH:mm:ss"); // Özel bir biçimle tarihi metne dönüştürür

            // Parse ve TryParse Metodları
            string tarihMetni = "25.09.2023";
            DateTime tarih;
            bool basarili = DateTime.TryParse(tarihMetni, out tarih);
            if (basarili)
            {
                Console.WriteLine("Başarıyla dönüştürüldü: " + tarih);
            }
            else
            {
                Console.WriteLine("Geçersiz tarih formatı");
            }
            #endregion

            #region MATH METODS
            // Temel Matematiksel İşlemler
            double mutlakDeger = Math.Abs(-5.4); // Mutlak değer hesaplar (5.4)
            double karekok = Math.Sqrt(25); // Karekök hesaplar (5.0)
            double usluSayi = Math.Pow(2, 3); // Üs alma işlemi yapar (8.0)

            // Trigonometrik İşlemler
            double sinDeger = Math.Sin(Math.PI / 6); // Sinüs hesaplar (0.5)

            // Logaritmik İşlemler
            double logDeger = Math.Log(100, 10); // Logaritma hesaplar (2.0)

            // Yuvarlama İşlemleri
            double yuvarlanmisDeger = Math.Round(3.7); // Yakın olan tam sayıya yuvarlar (4.0)
            double asagiYuvarlanmisDeger = Math.Floor(3.9); // Aşağı yuvarlar (3.0)

            // Min ve Max İşlemleri
            double minDeger = Math.Min(5, 8); // İki sayı arasındaki minimumu hesaplar (5.0)
            double maxDeger = Math.Max(5, 8); // İki sayı arasındaki maksimumu hesaplar (8.0)
            #endregion
        }
    }
}