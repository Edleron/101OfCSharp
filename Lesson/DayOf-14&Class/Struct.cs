namespace DayOf_14_Class {
    #region Struct Nedir ? 
    // Struct'lar yani yapılar class'lara çok benzerler. Struct ile yapıp class  ile yapamayacağız bir işlem yoktur diyebiliriz. Peki o halde struct yani yapılara neden ihtiyaç duyulur?
    // Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz.

    // Yapıların özellikleri:
    // Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
    // Diğer struct ya da sınıflardan kalıtım almazlar.
    // Interface'lerden kalıtım alabilirler.
    // new anahtar sözcüğü ile nesneleri yaratılabilir.
    // Sınıflar gibi metot, property ve field'lardan oluşurlar.
    // Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
    // Static üye barındırabilirler.

    // Class'lar referans tiplidir.
    // Struct'ler value tiplidir.

    // Rerafans tipliler, -> Heap'de tutulur
    // Değer tipliler, -> Stack'de tutulur

    // 16 bayt'a kadar, struct kulllanmak tavsiye edilirmiş.
    #endregion
    class Struct
    {
        static void Main(string[] args)
        {
            Dikdörtgen_Class valueOne = new Dikdörtgen_Class();
            valueOne.KısaKenar = 5;
            valueOne.UzunKenar = 10;

            Console.WriteLine(valueOne.Calculate());

            // Dikdörtgen_Struct valueTwo = new Dikdörtgen_Struct();
            Dikdörtgen_Struct valueTwo; // -> New'lemene gerek yok, Çalışır. Ayrıca bu kullanımda initial değerleini kendi atayamaz. Consturctor kurucak isen buna dikkat etmen gerekir.
            valueTwo.KısaKenar = 3;
            valueTwo.UzunKenar = 6;

            Console.WriteLine(valueTwo.Calculate());
        }
    }

    class Dikdörtgen_Class
    {
        public int KısaKenar;
        public int UzunKenar;

        public long AlanHesaola(){
            return this.KısaKenar + this.UzunKenar;
        }
    }

    struct Dikdörtgen_Struct
    {
        public int KısaKenar;
        public int UzunKenar;

        // Strcut'larda sadece parametli Constructors'e izin verir.

        public long Calculate(){
            return this.KısaKenar + this.UzunKenar;
        }
    }
}