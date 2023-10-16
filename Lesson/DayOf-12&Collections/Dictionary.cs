namespace DayOf_12_Collections
{
    #region Generic Collections

    #region DESCRIPTION ? 

    // C#'ta Dictionary<TKey, TValue> sınıfı, anahtar-değer çiftleri koleksiyonunu temsil eden ve anahtarlar aracılığıyla hızlı bir şekilde değerlere erişmenizi sağlayan tip güvenli bir koleksiyon sınıfıdır. 
    // Anahtar-değer çiftleri, her anahtarın yalnızca bir değere karşılık geldiği bir yapıyı ifade eder. İşte Dictionary<TKey, TValue> sınıfını kullanarak anahtar-değer çiftleri koleksiyonu oluşturma ve kullanma hakkında temel bilgiler:

    #endregion

    #region Dictionary Nedir?

    // Dictionary<TKey, TValue>, bir anahtar (TKey) ve bu anahtarın karşılığı olan bir değer (TValue) içeren bir koleksiyon türüdür. Anahtarlar benzersiz olmalıdır, yani aynı anahtara sahip iki öğe bulunamaz.

    #endregion

    #region Dictionary Oluşturma:

    // Dictionary<TKey, TValue> örneği oluşturmak için aşağıdaki gibi bir yol izleyebilirsiniz:
    // Bu örnekte, bir telefon rehberini temsil etmek için bir Dictionary örneği oluşturuluyor. Anahtarlar (kişilerin adları) bir dize (string) türünde ve değerler (telefon numaraları) bir tamsayı (int) türündedir.

    #endregion

    #region Değer Ekleme ve Erişme:

    // Dictionary'e değer eklemek için Add metodu kullanılır:
    // Değerlere erişmek için key'leri kullanabilirsiniz:

    #endregion

    #region  Değer Güncelleme ve Silme:

    // Değer güncelleme için de aynı key ile yeni bir değer ataması yapabilirsiniz:
    // Değer silme için Remove metodu kullanılır:

    #endregion

    #region  Anahtarları ve Değerleri Döngü İle Gezme:

    // Dictionary içindeki anahtarları ve değerleri döngü(for, foreach) ile gezerek işleyebilirsiniz:

    #endregion

    #region Dictionary Metodları:

    // Dictionary<TKey, TValue> sınıfı, birçok faydalı metod içerir. Örneğin ContainsKey, ContainsValue, Clear, Count, TryGetValue vb. gibi metotlar.

    #endregion

    #endregion

    class Dictionary
    {
        static void Main()
        {
            // Dictionary Oluşturma
            Dictionary<string, int> telefonRehberi = new Dictionary<string, int>();

            // Değer Ekleme
            telefonRehberi.Add("Ahmet", 5551234567);
            telefonRehberi.Add("Mehmet", 5559876543);

            // Değere Erişme
            int ahmetinTelefonu = telefonRehberi["Ahmet"]; // ahmetinTelefonu, 5551234567

            // Değer Güncelleme
            telefonRehberi["Ahmet"] = 5551112222;

            // Değer Silme
            telefonRehberi.Remove("Mehmet");

            // Anahtarları ve Değerleri Döngü İle Gezme
            foreach (var anahtar in telefonRehberi.Keys)
            {
                int deger = telefonRehberi[anahtar];
                Console.WriteLine($"{anahtar}: {deger}");
            }

            // Value ve Değerleri Döngü İle Gezme
            foreach (var değer in telefonRehberi.Value)
            {
                int anahtar = telefonRehberi[değer];
                Console.WriteLine($"{değer}: {anahtar}");
            }

            // Dictionary Metodları
            bool ahmetVarMi = telefonRehberi.ContainsValue("Ahmet"); // false
            bool mehmetVarMi = telefonRehberi.ContainsKey("Mehmet"); // false
            bool degerVarMi = telefonRehberi.ContainsValue(5551234567); // true
            bool degerVarMi = telefonRehberi.Remove(5551234567); // Silme işlemi
            telefonRehberi.Clear(); // Tüm öğeleri siler
            int elemanSayisi = telefonRehberi.Count; // 0

            // TryGetValue Metodu: Bir anahtarın değerini döndürür veya varsayılan değeri döndürür
            int telefonNumarasi;
            if (telefonRehberi.TryGetValue("Ahmet", out telefonNumarasi))
            {
                Console.WriteLine($"Ahmet'in Telefonu: {telefonNumarasi}");
            }
            else
            {
                Console.WriteLine("Ahmet rehberde bulunamadı.");
            }
        }
    }
}