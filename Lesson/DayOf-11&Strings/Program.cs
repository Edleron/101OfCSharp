using System;

namespace DayOf_11_Strings {

    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}