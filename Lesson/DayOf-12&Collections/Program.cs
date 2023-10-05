namespace DayOf_12_Collections {
    #region DESCRIPTION
    // Klasik programlama dillerinde array yani diziler çok önemli veri tipleridir. 
    // Birçok problemimizi diziler yardımıyla çözebiliriz ama bazı handikapları nedeniyle birçok sorun karşısında da yetersiz kalırlar.Bu sorunları şöyle sıralayabiliriz:
    
    // Oysa programlama dillerinde farklı türlerde verileri saklamaya ihtiyaç duyarız. Ve çoğu zaman ne kadar veri saklayacağımız program akışında belli olabilir. 
    // Koleksiyonlar tam da bu sorunları çözmek için dizilerin handikaplarından yaratılmıştır.

    // Array'lerin aksine koleksiyonların bazı tipleri; üzerinde çalıştıkları makinaın RAM'i yettiği sürece genişleyebilirler ve farklı türlerde veri tiplerini saklayabilirler.

    // Koleksiyonların elemanları object tipindedir. Hatırlayacak olursak öğrendiğimiz veri tipleri için object sınıfından türediklerini söylemiştik. 
    // Yani bu bir sorun değil, her türlü veriyi koleksiyonlar içerisinde saklayabiliriz.

    // Koleksiyonlar System.Collections namespace i yani isim uzayı altında bulunurlar.

    // DEZAVANTAJLARI
    // .Net platformda kullanıdığımız veri tipleri 2'ye ayrılır. Değer ve referans veri tipleridir. Değer tipleri belliğin stack bölgesinde tutulurken, Referans tipleri belleğin heap bölgesinde tutulur.
    // Değer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum
    // Referans Tipleri: string, object, class, interface, array, delegate, pointer

    // Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.

    // Koleksiyonlar verilerini object tipinde tutuyor demiştik. Object de bir referans tipi. 
    // Bu demek oluyor ki değer tipinde bir veriyi koleksiyona eklemek istediğimde bir boxing işlemi yapıyorum. 
    // Daha sonra elemanı okumak istediğimde de unboxing işlemi yapıyorum. Boxing ve unboxing işlemleri bilgisayar açısından maliyetli bir işlemdir. 
    // Koleksiyon içerisindeki eleman sayısının artışına bağlı olarak bu boxing ve unboxing işlemlerinin sayısı artacaktır. 
    // Buna bağlı olarakta uygulamanın performansı olumsuz yönde etkilenecektir.

    // Genel Amaçlı Koleksiyonlar
    // -> List
    // -> ArrayList
    // -> Dictionary
    // -> HashTable
    
    // Özel Amaçlı Koleksiyonşar
    // -> Hybrit Dictionary
    // -> Name Value Dictionary
    // -> String Collection
    // -> String Dictionary
    // -> Queue
    // -> Stack Sorted List

    // Bit Tabanlı Koleksiyonlar
    // -> Bit array

    // Boxing ve unboxing işlemlerinin performansa etkisine detaylı bakmak için şu makaleyi okumanızı öneririm:
    // -> https://www.buraksenyurt.com/post/Boxing-ve-Unboxing-Performans-Kritigi-bsenyurt-com-dan

    // Heap ve stack ile detaylı bilgi için lütfen aşağıdaki makalelere göz atınız.
    // -> https://www.gokhan-gokalp.com/stack-heap-kavramlari/
    // -> https://medium.com/yigit-xcodeproj/stack-ve-heap-arasindaki-fark-nedir-stack-vs-heap-c61e3d463dd7

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

}