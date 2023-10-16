#region NOTES

#region if - else ?

// "if-else" yapısı, belirli bir koşulu değerlendirmek ve bu koşula göre farklı kod bloklarını çalıştırmak için kullanılır. 
// "if-else" yapısı, belirli koşullar altında hangi kod bloğunun çalıştırılacağını kontrol etmemizi sağlar.

#endregion

#region switch ?

// ""switch-case" yapısı, bir değişkenin farklı değerlerini kontrol etmek ve her bir değere göre farklı işlemler yapmak için kullanılır.
// "if-else" ve "switch-case" yapıları, program akışını kontrol etmek için kullanılan önemli yapılar olup, koşullu ifadelerin ve çoklu durumların işlenmesine yardımcı olurlar.

#endregion


#endregion

using System;

namespace DayOf_6_Condition
{
    class Program
    {
        public static void Main(string[] args)
        {
            // if-else yapısı örneği
            int yas = 18;

            if (yas < 18)
            {
                Console.WriteLine("Ehliyet alamazsınız.");
            }
            else if (yas == 18)
            {
                Console.WriteLine("Ehliyet almaya hak kazandınız!");
            }
            else
            {
                Console.WriteLine("Ehliyet almaya hak kazandınız ve kullanabilirsiniz.");
            }

            // switch-case yapısı örneği
            int gun = 3;

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün");
                    break;
            }
        }
    }
}