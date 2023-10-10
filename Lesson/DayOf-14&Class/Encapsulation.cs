namespace DayOf_14_Class
{
    #region Encapsulation Nedir ?
    // C#'ın %100 nesne yönelimli bir dil olduğundan bahsetmiştik. Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak ya da korumaktır.
    // Örneğin siz bir propery yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin ama sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz. 
    // Bunu kapsülleme yaparak sağlayabilirsiniz. Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.
    // Bunlara aynı zamanda getter setter ismi verilmektedir.

    // Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. 
    // Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. 
    // Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.

    // Örnek
    // class Ogrenci {
        // private string name; //field

        // public string Name //property
        // {
            // get { return name; }
            // set { name = value; }
        // }
    // }

    // Yukarıda Ogrenci sınıfı içerisinde "name" isminde private bir field tanımı görüyorsunuz. Yani bu field'a sınıf dışında bir yerden erişilemez. 
    // Altındaysa "Name" isminde "name" field'ını geri döndüren Get metodu ve "name" field ına yeni değer atamasını yapabilen bir Set metodu barındıran bir property tanımı görüyoruz.

    // Burada property tanımlayarak "name" field'ını sınıf dışından yapılabilecek bilinçsiz atamalardan koruduk. 
    // Public property nin set metodu içerisinde bu field'a atanabilecek verileri kontrol edebilir ve müdahale edebiliriz.

    // Propert'lerin farlı bir kullanımı aşağıdan görebilirmisin !
    // class Person {
        // private int age=0;
        // public int Age
        // {
            // get { return age; }
            // set {
                // if (value > 0)
                // age = value;
            // }
        // }
    // }
    #endregion
    class Encapsulation
    {
        static void Main(string[] args)
        {
           Workers workesOne = new Workers("Edleron", "Doğan", 3, "Game Dev", 5);
           workesOne.BoostScore();
           workesOne.WorkenrBindings();

           workesOne.LossScore();
           workesOne.LossScore();
           workesOne.LossScore();
           workesOne.LossScore();
           workesOne.LossScore();
        }
    }

    class Workers
    {
        private string name;
        private string surname;
        private int id;
        private string departman;
        private int score;

        public string Name {
            get { return name;  }
            set { name = value; }
        }

        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }
        public string Departman { get => departman; set => departman = value; }
        public string Score 
        { 
            get => score; 
            set{
                if(value < 1) {
                    Console.WriteLine("Best Score time end => 1");
                    score = 1;
                } else {
                    score = value;
                }
            } 
        }

        public Workers()
        {
           
        }

        public Workers(string name, string surname, int id, string departman, int score)
        {
            Name = name;
            Surname = surname;
            Id = id;
            Departman = departman;
            Score = score;
        }

        public void WorkenrBindings(){
            Console.WriteLine("Çalışan Adı: {0}", this.Name);
            Console.WriteLine("Çalışan Soyadı: {0}", this.Surname);
            Console.WriteLine("Çalışan Id'si: {0}", this.Id);
            Console.WriteLine("Çalışan Departmanı: {0}", this.Departman);
            Console.WriteLine("Çalışan Departmanı: {0}", this.Score);
        }

        public void BoostScore(){
            this.Score = this.Score + 1;
        }

        public void LossScore(){
            this.Score = this.Score - 1;
        }
    }
}