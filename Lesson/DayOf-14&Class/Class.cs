namespace DayOf_14_Class
{
    #region Class
    // Sınıf Nedir, Neden İhtiyaç Duyarız ?

    // Sınıflar Nesne Yönelimli Programlamanın en önemli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.
    // Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik.    
    // Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.

    // Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.
    // Bir sınıfın temelde 2 tipte öğesi vardır; field/özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.
    #endregion

    #region Access Modifiers
    // Access Modifiers !

    // Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.
    // 1. Public : Her yerden erişilebilir.
    // 2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
    // 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir.
    // 4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
    #endregion

    #region Söz Dizimi
    // class SinifAdi
    // {
    // [Erişim Belirleyici] [Veri Tipi] Özellik Adı;
    // [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([Parametre Listesi])
    // {
    // Metod Komutları
    // }
    // }
    #endregion

    class Class
    {
        static void Main(string[] args)
        {
            Workers workesOne = new Workers();
            workesOne.Name = "Edleron";
            workesOne.Surname = "Doğan";
            workesOne.Id = 1;
            workesOne.Departman = "Game Dev";

            Workers workesTwo = new Workers();
            workesTwo.Name = "Edleron";
            workesTwo.Surname = "Doğan";
            workesTwo.Id = 2;
            workesTwo.Departman = "Game Dev";

            workesOne.WorkenrBindings();
            workesTwo.WorkenrBindings();
        }
    }

    // Examples
    class Workers
    {
        public string Name;
        public string Surname;
        public int Id;
        public string Departman;

        public void WorkenrBindings()
        {
            Console.WriteLine("Çalışan Adı: {0}", Name);
            Console.WriteLine("Çalışan Soyadı: {0}", Surname);
            Console.WriteLine("Çalışan Id'si: {0}", Id);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
