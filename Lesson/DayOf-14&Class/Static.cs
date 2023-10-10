namespace DayOf_14_Class {
    #region Statics
    // Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
    // Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz. Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.

    // Eğer bir class'tan static olmayan özelliklerine ulaşmak istediğimizde, o snıftan bir nesne(obje) oluşturmamız gerekmektedir.
    // Eğer nesne oluşturmadan yani class'ın instance almadan erişmek istersek static tanımlamamız gerekemktedir.
    #endregion

    #region Statics Class
    // Metotlar ve özellikler gibi sınıflar da static anahtar kelimesi ile oluşturulabilirler. 
    // Yukarıdaki örnekte de görebileceğiniz üzere normal sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. 
    // Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna okunabilirliği arttırmak için diyebiliriz.
    // Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.

    // Bir sınıfı static yapar isek, onun içerisinde bulunan tüm property'ler, tüm field'lar, tüm metodlar static olmak zorundadır.
    // Static class'larda kalıtım işlemi uygulamanaz.
    #endregion
    class Statics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0}", Workers.WorkersCount);

            Workers workesOne = new Workers("Edleron");
            Console.WriteLine("Çalışan Sayısı : {0}", Workers.WorkersCount);

            Workers workesTwo = new Workers("Wilkagul");
            Console.WriteLine("Çalışan Sayısı : {0}", Workers.WorkersCount);

            Console.WriteLine("Toplam Çalışan Sayısı : {0}",Operatiton.Test(workesTwo.workersCount, workesOne.workersCount));
        }
    }

    class Workers()
    {
        private string Name;
        private static int workersCount;

        public static int WorkersCount { get => workersCount; }

        // Static constructor'ların access modifiers'ları yoktur.
        // Her ne olursa olsun, 1 kere çalışır.
        // Her Init olduğunda setleme işlemi yapar. -> Ve bu program yaşam döngüsü boyunca 1 kere gerçekleşecektir.
        static Workers()
        {
            workersCount = 0
        }

        public Workers(string name)
        {
            this.Name = name;
            workersCount++;
        }
    }

    static class Operatiton
    {
        public static long Test(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
    }
}