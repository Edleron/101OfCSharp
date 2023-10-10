namespace DayOf_14_Class {    
    #region Constructor Kavramı
    // Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. 
    // Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

    // Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
    // Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
    // Public olarak bildirilmeleri gerekir.
    // Geri dönüş değerleri yoktur.
    // Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz. Metotları anlatırken aşırı yüklemeden bahsetmiştik. (Bkz: Metots Overloadings)

    // Notes
    // Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
    // Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; 
    // sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. 
    // Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.

    // Constructor içerisinde parametreler var ise ve değer atamaz ise; Constrularda Initial Değerler atanmış olur.
    #endregion
    class Constructors
    {
        static void Main(string[] args)
        {
            Workers workesOne = new Workers("Edleron", "Doğan", 3, "Game Dev");

            Workers workesTwo = new Workers();
            workesTwo.Name = "Edleron";
            workesTwo.Surname = "Doğan";
            workesTwo.Id = 2;
            workesTwo.Departman = "Game Dev";

            Workers workesThree = new Workers("Set", "Get");
            workesThree.Id = 2;
            workesThree.Departman = "Game Dev";

            workesOne.WorkenrBindings();
            workesTwo.WorkenrBindings();
            workesThree.WorkenrBindings();
        }
    }

    class Workers
    {
        public string Name;
        public string Surname;
        public int Id;
        public string Departman;

        // Constructors Overloadings
        public Workers(){
           
        }

        public Workers(string name, string surname){
            this.Name = name;
            this.Surname = surname;
        }

        // Constructors Overloadings
        public Workers(string name, string surname, int id, string departman){
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Departman = departman;
        }

        public void WorkenrBindings(){
            Console.WriteLine("Çalışan Adı: {0}", Name);
            Console.WriteLine("Çalışan Soyadı: {0}", Surname);
            Console.WriteLine("Çalışan Id'si: {0}", Id);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}

