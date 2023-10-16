#region NOTES

#region Metod Nedir ?

// Metodlar, C# programlarının temel yapı taşlarıdır. Bir metod, belirli bir işlemi gerçekleştiren ve belirli bir adı olan bir kod bloğudur. 
// Metodlar, kodunuzu modüler hale getirmenizi ve aynı kod parçacığını tekrar tekrar kullanmanızı sağlar. 
// Bir metod tanımlandığında, bu metodu çağırarak belirli bir görevi gerçekleştirebilirsiniz.

// Metotları programı küçük parçalara ayrıştırmak için kullanırız. Büyük bir işi tek bir metot içinde yazmak yerine küçük parçalara ayırarak yazmak daha doğru bir yaklaşımdır.
// Bir fonksiyona parametre aktarırken değer veya referans tipinde paramtere verebiliriz.
// Baska bir class'ta yaratılan metod'a ulaşmak için onun instance alıp, erişim belirteçkerine dikkat ederek, o Metoda o şekilde ulaşabiliriz.

// Metodlar geriye dönüş değerleri döndürebilir, Eğer geriye dönüş istemiyor isek void ile boş bir değer döndürebiliriz.
// Geriye değer döndürmek istediğimizde return keyword'ünü kullanmamız gerekemktedir.

#endregion

#region Out Kavramı Nedir ?

// "out" parametresi, bir metodun değeri döndürmek yerine, birden fazla değeri bir metottan döndürmek için kullanılır. 
// "out" parametresi, bir metoda parametre olarak geçirilen değişkenin değerini değiştirme yeteneğine sahiptir.

// Out anahtar kelimesi ref anahtar kelimesi ile aynı işi yapıyor diyebiliriz. Arada sadece birkaç fark var.
// Out olarak kullanılmak istenen değişken önüne mutlaka "out" yazılmalıdır.
// out değişkeninin bir ilk değeri olmak zorunda değildir. Hatırlarsanız bu ref kullanırken zorunluydu.

#endregion

#region Ref Kavramı Nedir ?

// "ref" parametresi, bir metoda geçirilen değişkenin değerini metot içinde değiştirmenizi sağlar. "ref" parametresi, değeri bir metottan diğerine iletmek için kullanılır.
// Değer tipleri metoda bit bit kopyalanır. Yani int bir değişkeni parametre olarak değer tipinde bir fonksiyona verdiğimizde; fonksiyon çalışırken bellekten integer bir değişkeni saklayabilecek kadar yer ayrılır. 
// Gönderilen parametre orada saklanır Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. 
// Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.
// Değer Tiplerini şu şekildedir: int, long, float, double, decimal, char, bool, byte, short, struct, enum

// Ref keyword'u, metod içerisine referans'larını verdiği için, metod kapsamında değişiklik yaptığımızda bellek'teki adress tutulduğu için, değerler değişir.

// Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
// ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.

// "out" parametresi, bir metottan birden fazla değeri döndürmek için kullanılırken, "ref" parametresi bir değişkenin değerini metot içinde değiştirmek için kullanılır.

#endregion

#region Metod Overloading ?

// Metod overloading (aşırı yükleme), C# programlamasında aynı metodun isminin aynı olmasına rağmen farklı parametrelerle birden fazla kez tanımlanmasını ifade eder. 
// Bu sayede aynı isme sahip farklı işlevleri olan birden fazla metodu aynı sınıf içinde kullanabilirsiniz. 
// Metod overloading, kodun daha okunabilir ve kullanılabilir olmasına yardımcı olur ve aynı işlevi gerçekleştiren metodların aynı isim altında gruplanmasını sağlar.

#endregion

#region Rekursif Metod ?

// Rekürsif metodlar, kendilerini çağıran ve daha küçük veya daha basit bir sorun üzerinde çalışan metotlardır. 
// Birçok matematiksel ve algoritmik problemin çözümünde kullanılırlar. Örnek olarak, faktöriyel hesaplama işlemi için rekürsif bir metot kullanabilirsiniz.

// Rekürsif metotlar ilk öğrenildiğinde içselleştirilmesi ve kullanılması zor metotlardır. Ama yazılımın ilerleyen yıllarında kullanımı oturur ve bir çok soruna rekürsif metotları kullanarak çözüm getirebilirsiniz. 
// O nedenle acele etmemek gerek :)
// Çok sık olmasa da bazen fonksiyonun kendi kendini çağırmasına ihtiyaç duyarız. 
// For döngüsü karmaşık bir kod yazarak da bu ihtiyacı karşılamak mümkün. Rekürsif fonksiyonlar ise tam da bu ihtiyaç için ortaya koyulmuştur.
// Rekürsif fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanırken çok dikkatli olmak gerek. En büyük sorunlardan biri sonsuz döngüye neden olmalı. 
// Bu da System.StackOverflowException olarak bilinen hataya neden olur. Yani belleğin stack bölgesinde bu fonksiyon çağrımı için ayrılan alan tükenmiştir. Yinelemeli olarak yaptığınız işe bağlı olarak risk de artar.
// Aşağıdaki örneği inceleyerek ve hatta kağıt üzerinde yazarak yinelemeli fonksiyonların kullanımını daha iyi oturtabilirsiniz.

#endregion

#region Extension Metod ?

// Extension metotları, C# programcılarının mevcut bir sınıfa veya veri türüne yeni metotlar eklemelerine olanak tanır. Bu, .NET Framework veya başka bir kütüphane tarafından sağlanmayan özel işlevselliği eklemek için kullanışlıdır.
// Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.

// Extension metot yazarken dikkat etmemiz gereken bir kaç kural vardır. Şu şekilde :
// Static bir class içerisinde static bir metot olarak yazılmalılar.
// Extension metod da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

// Extension metotların kullanımını oturtmanın en kolay yolu öncelikle işi yapacak olan metodu istenileni karşılayacak şekilde yazmaktır. 
// Daha sonradan class ve metodu static yaparak ve genişletilecek veri tipine bağlı parametrenin başına this anahtar kelimesi ekleyerek kullanabilirsiniz.

#endregion

#endregion

using System;

namespace DayOf_9_Metods
{
    class Program
    {

        // Metod (Method) Örneği
        public static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        // "out" Parametresi Örneği
        public static void BolumVeKalan(int bolunen, int bolen, out int bolum, out int kalan)
        {
            bolum = bolunen / bolen;
            kalan = bolunen % bolen;
        }

        // "ref" Parametresi Örneği
        public static void Arttir(ref int sayi)
        {
            sayi++;
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        static void Main()
        {
            // Metod (Method) Kullanımı
            int sonuc = Topla(5, 3);
            Console.WriteLine("Toplam: " + sonuc); // Çıktı: "Toplam: 8"

            // "out" Parametresi Kullanımı
            int bolum, kalan;
            BolumVeKalan(10, 3, out bolum, out kalan);
            Console.WriteLine("Bölüm: " + bolum); // Çıktı: "Bölüm: 3"
            Console.WriteLine("Kalan: " + kalan); // Çıktı: "Kalan: 1"

            // "ref" Parametresi Kullanımı
            int sayi = 5;
            Arttir(ref sayi);
            Console.WriteLine("Artırılmış Sayı: " + sayi); // Çıktı: "Artırılmış Sayı: 6"           

            // Metod Overloading
            HesapMakinesi hesap = new HesapMakinesi();
            int sonuc1 = hesap.Topla(5, 3); // İki tamsayıyı toplar
            double sonuc2 = hesap.Topla(2.5, 3.7); // İki ondalıklı sayıyı toplar
            int sonuc3 = hesap.Topla(1, 2, 3); // Üç tamsayıyı toplar

            Console.WriteLine("Sonuç 1: " + sonuc1); // Çıktı: "Sonuç 1: 8"
            Console.WriteLine("Sonuç 2: " + sonuc2); // Çıktı: "Sonuç 2: 6.2"
            Console.WriteLine("Sonuç 3: " + sonuc3); // Çıktı: "Sonuç 3: 6"

            // Rekursif Metods
            Factorial(3);
            // Extensions Metods
            string kelime = "merhaba";
            string yeniKelime = kelime.UppercaseFirstLetter(); // "Merhaba"
        }
    }

    public class HesapMakinesi
    {
        // İki tamsayıyı toplayan metot
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // İki ondalıklı sayıyı toplayan metot
        public double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        // Üç tamsayıyı toplayan metot
        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
    }

    public static class StringExtensions
    {
        public static string UppercaseFirstLetter(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}