namespace DayOf_12_Collections
{
    #region Generic Collections

    #region Generic Collections Nedir ? 

    // Generic Collections, C#'ta veri yapılarını temsil eden ve içerdikleri veri türünü parametre olarak alan sınıflardır. 
    // Bu, koleksiyonları belirli bir veri türüne özgü olmaktan kurtarır ve aynı koleksiyon türünü farklı veri türleri için kullanmanıza olanak tanır.

    #endregion

    #region System.Collections.Generic Namespace

    // Generic koleksiyon sınıfları, "System.Collections.Generic" isim alanında bulunur. Bu nesneleri kullanmak için bu isim alanını projenize eklemeniz gerekecektir.

    #endregion

    #region Generic List (List<T>) Örneği:

    // List<T>, dinamik boyuta sahip bir dizi gibi davranan ve genellikle kullanılan bir koleksiyon türüdür. İçerisinde sakladığı tüm veriler aynı türde olmalıdır.

    #endregion

    #region Generic Dictionary (Dictionary<TKey, TValue>) Örneği:

    // Dictionary<TKey, TValue>, bir anahtar-değer çifti koleksiyonudur. Bu koleksiyon, bir anahtar ile ilişkilendirilmiş bir değeri saklar.

    #endregion

    #region  Generic Queue (Queue<T>) ve Stack (Stack<T>) Örneği:

    // Queue<T> ve Stack<T>, sırayla işlem yapmak için kullanılan koleksiyon türleridir. Queue<T>, bir kuyruk (FIFO - İlk Giren İlk Çıkar) işlemi yaparken, Stack<T> ise bir yığın (LIFO - Son Giren İlk Çıkar) işlemi yapar.

    #endregion

    #region  Generic Collections Avantajları:

    // Tip güvenliği: Veri türü uyumsuzluğunu en aza indirir.
    // Performans: Özelleştirilmiş koleksiyonlar, performansı artırabilir.
    // Kod tekrarı: Aynı koleksiyon türünü farklı veri türleri için yeniden kullanma olanağı sağlar.

    #endregion

    #endregion

    class GenericCollections
    {
        static void Main()
        {
            // Generic List (List<T>) Örneği
            List<int> integerList = new List<int>();
            integerList.Add(1); // Listeye bir tamsayı ekler
            integerList.Add(2);
            integerList.Add(3);

            List<string> stringList = new List<string>();
            stringList.Add("Merhaba"); // Listeye bir dize ekler
            stringList.Add("Dünya");

            // Generic Dictionary (Dictionary<TKey, TValue>) Örneği
            Dictionary<string, int> telefonRehberi = new Dictionary<string, int>();
            telefonRehberi.Add("Ahmet", 5551234567); // Rehbere kişi ve telefon numarası ekler
            telefonRehberi.Add("Mehmet", 5559876543);

            // Generic Queue (Queue<T>) ve Stack (Stack<T>) Örneği
            Queue<string> kuyruk = new Queue<string>();
            kuyruk.Enqueue("Öğrenci1"); // Kuyruğa öğrenci ekler
            kuyruk.Enqueue("Öğrenci2");

            Stack<int> yigin = new Stack<int>();
            yigin.Push(1); // Yığına bir tamsayı ekler
            yigin.Push(2);

            // LIST METODS
            #region LIST METODS
            // Bir integer listesi oluşturuyoruz.
            List<int> integerList = new List<int>();

            // Add metodu: Listeye öğe ekler.
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);

            // Count özelliği: Listenin öğe sayısını döndürür.
            int elemanSayisi = integerList.Count; // elemanSayisi, 3 olacaktır

            // Contains metodu: Belirli bir öğenin listede olup olmadığını kontrol eder.
            bool varMi = integerList.Contains(2); // varMi, true olacaktır

            // IndexOf metodu: Belirli bir öğenin indeksini döndürür.
            int indeks = integerList.IndexOf(2); // indeks, 1 olacaktır

            // Remove metodu: Belirli bir öğeyi listeden kaldırır.
            integerList.Remove(2); // Şimdi liste [1, 3] içerir.

            // ToArray metodu: Listenin öğelerini bir diziye kopyalar.
            int[] dizi = integerList.ToArray(); // dizi, [1, 3] olacaktır

            // Clear metodu: Listenin tüm öğelerini temizler.
            integerList.Clear(); // Şimdi liste boş.

            // Sort metodu: Listeyi sıralar.
            List<string> stringList = new List<string>() { "elma", "armut", "çilek" };
            stringList.Sort(); // Artan sıraya göre sıralar (alfabetik olarak).

            // Reverse metodu: Listeyi ters çevirir.
            stringList.Reverse(); // Ters çevirir (çilek, armut, elma).

            // ForEach metodu: Listeyi döngü içinde işler.
            stringList.ForEach((meyve) => Console.WriteLine(meyve));
            // Çıktı: çilek, armut, elma

            // Person sınıfından örnekler içeren bir List oluşturuyoruz.
            List<Person> personList = new List<Person>();

            // Listeye yeni Person nesneleri ekliyoruz.
            personList.Add(new Person("Ali", 30));
            personList.Add(new Person("Ayşe", 25));
            personList.Add(new Person("Mehmet", 35));

            // Listeyi dolaşarak her bir Person nesnesini yazdırıyoruz.
            foreach (Person person in personList)
            {
                Console.WriteLine($"Adı: {person.Name}, Yaşı: {person.Age}");
            }

            // ForEach metodu ile her bir Person nesnesini işleyebiliriz.
            personList.ForEach((person) => Console.WriteLine($"Adı: {person.Name}, Yaşı: {person.Age}"));
            #endregion
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}