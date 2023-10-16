#region OOP Nedir ?
// Nesne Yönelimli Programlama (OOP), bir yazılım geliştirme yaklaşımıdır ve aynı zamanda bir felsefi temele dayanır. 
// OOP'nin felsefesi, yazılım geliştirme sürecini daha iyi anlamamıza, yönetmemize ve düzenlememize yardımcı olur. İşte OOP'nin felsefesini açıklayan bazı ana noktalar:

// OOP yaklaşımı reel hayatın, birebir programlama paradigmalarına uyarlanabileceğini savunmaktadır. Nesne yönelimli yaklaşım gerçek hayattaki modellerin yazılıma adapte edilebileceğini savunan bir yaklaşımdır.

// Varlık Odaklılık (Entity-Centric): OOP, programlamadaki temel varlıkları (nesneleri) vurgular. Bu varlıklar, 
// gerçek dünyadaki nesneleri veya soyut kavramları temsil edebilir. Her nesnenin özellikleri (veri) ve davranışları (metodlar) vardır. Bu, yazılımı daha gerçekçi bir şekilde modellememize yardımcı olur.

// Soyutlama (Abstraction): OOP, karmaşıklığı azaltmak ve gereksiz ayrıntılardan kaçınmak amacıyla soyutlama kavramını vurgular. 
// Bu, sadece gerekli olan bilgilere odaklanmamıza olanak tanır ve ayrıntıları gizler. Bu, bir nesneyi sadece onun halka açık metotlarına erişerek kullanabilmemize benzer.

// Miras (Inheritance): OOP, bir nesnenin diğer nesnelerden özelliklerini ve davranışlarını miras alabilmesine izin verir. Bu, kodun yeniden kullanılabilirliğini artırır ve kodun organizasyonunu iyileştirir.

// Çok Biçimlilik (Polymorphism): OOP, aynı arayüzü uygulayan nesnelerin farklı davranışlar sergileyebilmesine olanak tanır. 
// Bu, farklı nesneleri genel bir arayüz kullanarak bir arada kullanabilmemize olanak tanır. Bu, kodun esnekliğini artırır.

// Sarmalama (Encapsulation): OOP, veri ve işlevselliği bir arada tutarak nesnelerin kapsüllemesine (encapsulation) izin verir. 
// Bu, nesnenin iç detaylarını gizler ve sadece belirli metotlar aracılığıyla erişilebilmesine olanak tanır. Bu, kodun güvenliğini artırır ve dışarıdan yanlışlıkla verilere müdahaleyi engeller.

// OOP'nin felsefesi, yazılım geliştiricilere daha düzenli, organize ve sürdürülebilir kod yazmalarına yardımcı olur. 
// Ayrıca, gerçek dünyadaki karmaşık problemleri daha iyi modellememize ve çözmemize imkan tanır. Bu nedenle OOP, yazılım geliştirme sürecini daha etkili ve anlaşılır hale getiren bir felsefi yaklaşım olarak kabul edilir.

// Nesne (Object): Nesne, OOP'nin temel yapı taşıdır ve gerçek dünyadaki bir varlığı veya soyut bir kavramı temsil eder. Bir nesne, verileri (özellikler veya öznitelikler) ve bu verilere uygulanan işlevselliği (metotlar veya işlevler) içerir. 
// Örneğin, bir araba nesnesi, rengi, hızı, markası gibi özelliklere sahip olabilir ve hız artırma veya frenleme gibi işlevselliği gerçekleştirebilir.
// Nesneler programlama paradigmalarında, class'lara denk gelmektedir.

// Obje (Object): "Obje" terimi, Bir "nesne" bir sınıfın bir örneğidir ve programlamada bu terim sıklıkla "obje" olarak ifade edilir. 
// Yani, "nesne" ve "obje" terimleri genellikle aynı anlamda kullanılır ve bir sınıfın bir örneğini ifade ederler.    
// Bir class'ın örneği instance alınarak, o Nesnenin varlığı obje olarak kullanılarak programala paradigmlarında kullanılmak üzere nesne(class) hazır hale getirilir. 
#endregion

#region OOP Temel Prensipleri Nedir ?
// 1-) Abstraction (Soyutlama) Nedir ?       --->
// 2-) Encapsulation (Kapsülleme) Nedir ?       --->
// 3-) Polymorphism (Çok Biçimcilik) Nedir ?    ---> 
// 4-) Inheritance (Kalıtım, Miras)  Nedir ?    --->
#endregion

using System;
using DayOf_15_OOP.Inheritance;

namespace DayOf_15_OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            tohumluBitki.Solunum();
            tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalma();
        }
    }
}