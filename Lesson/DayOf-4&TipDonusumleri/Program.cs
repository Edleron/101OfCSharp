#region NOTES

#region Implicit (Otomatik) Dönüşüm:

// Bu tür dönüşümler, veri kaybı olmayacaksa C# tarafından otomatik olarak yapılır. Genellikle daha büyük bir veri türünden daha küçük bir veri türüne yapılır. Örneğin, int bir değeri double türüne dönüştürmek:

#endregion

#region Explicit (Belirli) Dönüşüm:

// Bu tür dönüşümler, açık bir şekilde belirtilmelidir ve veri kaybı olabilir. Bu dönüşümler cast operatörü (veri_türü) ile gerçekleştirilir. Örneğin, double bir değeri int türüne dönüştürmek:

#endregion

#region Convert Sınıfı ile Dönüşüm:

// Convert sınıfı, farklı veri türleri arasında dönüşümler yapmanıza yardımcı olur. Örneğin, bir metin (string) değerini bir tamsayıya dönüştürmek:

#endregion

#region Parse Metodu ile Dönüşüm:

// Metin olarak temsil edilen sayıları, ilgili veri türüne dönüştürmek için Parse metodunu kullanabilirsiniz. Örneğin, bir metin sayısını bir tamsayıya dönüştürmek:

#endregion

#region TryParse Metodu ile Dönüşüm (Güvenli Dönüşüm):

// TryParse metodu, metin bir değeri veri türüne dönüştürmeye çalışırken hata olasılığına karşı güvenli bir yol sağlar. Eğer dönüşüm başarılı olmazsa, hata durumunu kontrol etmek mümkün olur.

#endregion

#endregion

using System;

namespace DayOf_4_TipDönüsümleri
{
    class Program 
    {
        public static void Main(string[] args){
            // Implicit (Otomatik) Dönüşüm
            int tamSayi = 42;
            double ondalikSayi = tamSayi; // Otomatik dönüşüm, veri kaybı olmadan gerçekleşir

            // Explicit (Belirli) Dönüşüm - Bu işleme cast etme işlemi adı'da verilir.
            double ondalikSayi2 = 42.75;
            int tamSayi2 = (int)ondalikSayi2; // Belirli dönüşüm, ondalık kısmı atar, tamSayi2 42 olur

            // Convert Sınıfı ile Dönüşüm
            string metinSayi = "123";
            int sayi = Convert.ToInt32(metinSayi); // Convert sınıfı ile dönüşüm

            // Parse Metodu ile Dönüşüm
            string metinSayi2 = "456";
            int sayi2 = int.Parse(metinSayi2); // Parse metodu ile dönüşüm

            // TryParse Metodu ile Dönüşüm (Güvenli Dönüşüm)
            string metinSayi3 = "789";
            int sayi3;
            if (int.TryParse(metinSayi3, out sayi3))
            {
                // Dönüşüm başarılı, sayi3 değişkenine değer atanır
            }
            else
            {
                // Dönüşüm başarısız, hata durumuyla başa çıkılabilir
            }
        }
    }
}