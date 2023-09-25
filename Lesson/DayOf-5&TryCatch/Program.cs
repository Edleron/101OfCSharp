#region NOTES

#region Try-Catch Nedir ?

// C# programlamada "try-catch" yapısı, hata işleme (exception handling) için kullanılan bir kontrol yapısıdır. 
// Programın çalışması sırasında oluşabilecek istisnai durumları (hataları) ele almak ve bu hataların programın çökmesini önlemek için kullanılır. 
// "try" bloğunda potansiyel olarak hata üretebilecek kodlar yer alırken, "catch" bloğu, hata oluştuğunda ne yapılacağını belirtir.

#endregion

#endregion

using System;

namespace DayOf_5_TryCatch
{
    class Program 
    {
        public static void Main(string[] args){
            try
            {
                // Potansiyel olarak hata üretebilecek kodlar burada bulunur
                int sayi1 = 10;
                int sayi2 = 0;
                int sonuc = sayi1 / sayi2; // Bu satırda bir hata oluşur (Sıfıra bölme hatası)
            }
            catch (Exception ex)
            {
                // Hata yakalandığında ne yapılacağını belirtiriz
                Console.WriteLine("Hata Oluştu: " + ex.Message);
            }
            finally
            {
                // Bir kod satırı hata alsın yada almasın, son çıktıyı üreten yerdir.
                 Console.WriteLine("İşlem Tamamlandı ");
            }
        }
    }
}