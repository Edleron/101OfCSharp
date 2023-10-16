namespace DayOf_12_Collections
{
    #region Generic Collections

    #region DESCRIPTION ? 

    // C#'ta ArrayList, eski bir koleksiyon sınıfıdır ve .NET Framework'ün önceki sürümlerinde sıkça kullanılmıştır. 
    // Ancak daha modern ve tip güvenli koleksiyonlar olan List<T> ve diğer generic koleksiyonlar (List<T>, Dictionary<TKey, TValue>, vb.) kullanılmaya başlandığından, ArrayList kullanımı genellikle önerilmez. 
    // ArrayList yerine generic koleksiyonları kullanmanız, tip güvenliğini artırır ve daha performanslı kod yazmanıza olanak tanır.

    #endregion

    #region ArrayList Nedir?

    // ArrayList, .NET Framework tarafından sağlanan bir koleksiyon sınıfıdır ve içerisinde herhangi bir veri türünü saklayabilir. 
    // Bu, farklı veri türlerini aynı koleksiyon içinde bulundurmanıza olanak tanır, ancak tip güvenliği konusunda dikkatli olmanızı gerektirir.   

    #endregion

    #region ArrayList Oluşturma ve Öğe Ekleme:

    // ArrayList oluşturmak için ArrayList sınıfının bir örneğini oluşturabilirsiniz ve Add metoduyla öğeler ekleyebilirsiniz:

    #endregion

    #region ArrayList İçindeki Öğelere Erişim:

    // ArrayList içindeki öğelere erişmek için indeks numarasını kullanabilirsiniz:

    #endregion

    #region ArrayList Döngüsü:

    // ArrayList öğelerini döngü içinde işlemek için foreach veya for döngüsü kullanabilirsiniz:

    #endregion

    #region ArrayList Metodları:

    // ArrayList, birçok farklı metod ve özellik sunar. Örneğin, Remove, Contains, Count gibi metodlarla öğeleri kaldırabilir, içerik kontrolü yapabilir ve öğe sayısını alabilirsiniz.

    #endregion

    #region ArrayList Kullanırken Dikkat Edilmesi Gerekenler:

    // ArrayList içinde her türlü veri türünü saklayabilirsiniz, ancak tip güvenliği kaybolabilir.
    // Öğelere erişirken tür dönüşümü yapmanız gerekebilir.
    // Performans açısından generic koleksiyonlar (List<T>, Dictionary<TKey, TValue>, vb.) genellikle tercih edilir.

    #endregion

    #endregion

    class ArrayList
    {
        static void Main()
        {
            // ArrayList Oluşturma ve Öğe Ekleme
            ArrayList arrayList = new ArrayList();
            arrayList.Add(42); // Integer ekleniyor
            arrayList.Add("Merhaba"); // Dize ekleniyor
            arrayList.Add(true); // Boolean ekleniyor

            // ArrayList İçindeki Öğelere Erişim
            int sayi = (int)arrayList[0]; // İlk öğe (integer) alınıyor
            string metin = (string)arrayList[1]; // İkinci öğe (dize) alınıyor
            bool dogruMu = (bool)arrayList[2]; // Üçüncü öğe (boolean) alınıyor

            // ArrayList Döngüsü
            foreach (var eleman in arrayList)
            {
                Console.WriteLine(eleman); // Öğeler yazdırılıyor
            }

            // ArrayList Metodları
            arrayList.Remove("Merhaba"); // Belirli bir öğe kaldırılıyor
            bool iceriyorMu = arrayList.Contains(42); // Bir öğenin varlığı kontrol ediliyor
            int elemanSayisi = arrayList.Count; // Öğe sayısı alınıyor
            arrayList.Sort(); // Sıralama Yapar.
            arrayList.BinarySearch(9) // Bİnary search değerini gösterir.
            arrayList.Reverse();    // Tersine çevirir.
            arrayList.Clear();    // Listeyi siler.
        }
    }
}