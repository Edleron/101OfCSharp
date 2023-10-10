namespace DayOf_14_Class {
    #region 
    // Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum'lardan faydalanırız.
    // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
    // Yukarıda Gunler enum'ını görüyorsunuz. Enum lar default olarak 1'den başlar.
    // Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. Eğer Pazartesinin 1. gün oldugu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi**

    // Enum'lar enumator'ın kısaltması anlamına gelmektedir.
    #endregion
    class Enum
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Gunler.pazar);
           Console.WriteLine((int)Gunler.pazar);

           int sicaklik = 25;

           if (sicaklik < (int)HavaDurumu.Normal)
           {
                Console.Writeline("Normalin Altında")
           }
        }
    }

    enum Gunler{
        Pazartesi = 0,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu {Soguk = 1, Normal = 20, Sıcak = 30, CokSicak = 40}
}
