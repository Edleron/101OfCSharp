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

#region Inheritance
// Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir. Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.

// Kalıtım çok soyut bir kavram olması itibariyle anlaşılması zor bir konudur. Bunun için en kolay anlaşılabilecek örnekler üzerinden denenmesinin faydalı olduğunu düşünüyorum. 
// Bu da Canlılar - Hayvanlar - Bitkiler ayrımı ile anlaşılabilir.
#endregion

#region Polymorphism
// Polimorfizm, aynı isimle çağrılan metotların farklı davranışlar sergileyebilmesine olanak tanır. 
// Bu, bir üst sınıftan miras alınmış metotları alt sınıflarda yeniden tanımlayarak veya arayüzleri uygulayarak gerçekleştirilebilir. Bu, kodun daha esnek ve genişletilebilir olmasına olanak tanır.

// Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. 
// Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.

// Base Class'ta virtual anatar kelimesiyle, sanal metodlar yaratılır. Base class'ı kalıtım alam sınıflar üst sınıfta yazılan ve daha sonrasında alt sınıflarda yeniden yazılabilen -> biçimi değiştirilem, biçimi değiştirilerek yeni bir şeyler katılan,
// Yada içeriği tamamen değiştirlen metodlara override keyword ile yeniden tanımlama yaparak, üst sınıftaki base kodları yeniden düzenleyebiliriz. Buda kodumuza esneklik ve bazrı ekstra ayrıcalıklar katacaktır. //
// Ayrıca alt tabadaki tipindeki nesneler, gerçekte hangi alt sınıfın örneği olduklarını gözetmeksizin doğru davranışı sergilerler.

// Sealed Class:
// "Sealed" kelimesi, bir sınıfın başka bir sınıf tarafından miras alınamayacağını belirtmek için kullanılır. 
// Sealed sınıflar, özellikle belirli bir sınıfın özgün davranışını korumak istediğinizde kullanışlıdır. Aşağıda, bir "Sealed Class" örneği verilmiştir:
#endregion

#region Interface
// Interface Nedir?
// Bir interface (arayüz), C# programlama dilinde bir referans tipi olarak kabul edilir ve sınıflar arasında belirli bir davranışı veya yeteneği tanımlamak için kullanılır. 
// Interface, içerisinde sadece metot bildirimleri, özellikler (get ve set yöntemleri) ve olaylar (events) bulunan bir sözleşme gibidir. 
// Bir sınıf, bir interface'i uyguladığında, bu sınıf o interface'de tanımlanan tüm metotları ve özellikleri içermek zorunda kalır. 
// Interface'ler, çoklu mirasın yerine kullanılabilen bir yol sunar.

// Interface Ne İşe Yarar?
// Kodun Soyutlanmasını Sağlar: Interface'ler, sınıflar arasında belirli bir davranışı veya sözleşmeyi tanımlamak için kullanılır. Bu sayede sınıfların belirli bir arayüzü uygulaması sağlanır.
// Çoklu Miras İmkanı Sağlar: C# dilinde, bir sınıf yalnızca tek bir sınıfı miras alabilir (inherit), ancak bir sınıf birden fazla interface'i uygulayabilir. Bu, çoklu mirasın sınırlamalarını aşmanın bir yoludur.
// Kodun Daha Okunabilir ve Yönetilebilir Olmasını Sağlar: Interface'ler, kodun daha anlaşılır ve yönetilebilir olmasına yardımcı olur. Aynı arayüzü uygulayan sınıflar, benzer davranışları paylaşır ve bu, kodun düzenli ve tutarlı olmasını sağlar.

// Kurallar
// Interface'ler I ile kelimeye başlar,
// İçindeki metod gövdeleri boş olmak zorundadır.
// Interface içerisindeki propert'lere değer ataması yapılmaz.
// Interface'ler sadece class'lara implemente edilir.

// Interface'ler sadece implemente edilen sınıfa ne iş yaptığının arayüz bilgisini veren iş gibi düşünebilirsiniz. !
// Interface'ler'den kalıtım alan sınıfın yani çerçevesinin çizilmesine yardımcı olur.
// Farklı sorumlulukları verme ve class'ı bilgilendirme biçimidir !
// Class aynı işi kendi tarzında yapma olanaığına sahip olur.

// Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. Sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
// Kesin belirlenmiş bir kural olmamasıyla beraber interface isimleri "I" ile başlar. I ile başlayan bir isim gördüğümüzde kolaylıkla bunun bir arayüz olduğunu anlarız. Dolayısıyla standartlara bağlı kalmakta fayda var.
// Interface içerisindeki property'lere bir değer ataması yapılmaz, metotların ise gövdesi yazılmaz. Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler. Ve bir sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
// Peki interface'lere neden ihtiyaç duyarız? Kalıtım alan sınıfın sorumluluğunun çerçevesinin çizilmesine yardımcı olur diyebilir. 
// Aynı sorumluluğu başka bir yoğurt yiyiş tarzıyla yapması gereken bir sınıf geldiğinde aynı interface den kalıtım alır ama yapacağı işi farklı şekilde yapar.
#endregion

#region Abstract
// Abstract class'lar Nedir ?
// Abstract class'ları sadece kalıtım olarak düşünebileceğiniz base sınıflardır.
// Bazı özellikleri ile class'lara benzer iken, bazı özellikleri ise interface'lere benzemektedir.
// Abstract class'ları virtual metodlar ve interface metodların birleşimi gibi düşünebilirisinz.
// Normal sınıflar gibi new anahtar kelimesiyle üretilemezler, Instance'ları alınamaz.
// Sınıflara benzerler ama nesneleri türetilemez.
// Tek başlarına anlamları olan yapılar değillerdir.
// Muhakkak bir sınıf ile berebaer kullanılması gerekmektedir.
// Interface'ler gibi metod bildiri yapabiliriz -> Yani gövdesine boş olan metodlar ekleyebiliriz.
// Virtual metodlar override edilebilirken, abstract class'ların metodlarıda override edilebilir.
// Bir abstract class içerisine abstract metodlar yazılabilir.
// Miras alan sınıflar, Eğer base abstract class'ta, abstract metod'lar var ise, onu override etmek zorundadır.
// Bir sınıf sadece bir tane abstract class'tan miras alabilir.
// Abstract sınıflar baska abstract class'lardan miras alabilir.

// Abstract Class
// Abstract class'ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. 
// Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler. Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

// Abstract Class Özellikleri
// Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
// Interface ler gibi metot bildirimi yapabilirsiniz.
// Sanal metotları override eder gibi abstract metotlar override edilebilir.
// Abstract metotların gövdesi yazılamaz.
// Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
// Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
// Abstract sınıf başka bir abstract sınıftan kalıtım alabilir. 
// Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur. Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.

// NOT 1
// Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim belirtecinden sonra "abstract" anahtar kelimesi mutlaka yazılmalıdır.

// NOT 2
// Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.


// SORU - 1
// Bir sınıfın en fazla kaç farklı sınıftan kalıtım alabilir?
// Cevapl - 1

// SORU -2
// Alt sınıftan miras veren temel sınıfın açmış olduğu metotları çağırmak için aşağıdaki anahtar kelimelerden hangisi kullanılır?
// Cevap -> Base

// SORU -3
// Virtual anahtar kelimesi ile yazılan metodun alt sınıfta yeniden biçimlendirilmesi için kullanılması gereken anahtar kelime aşağıdakilerden hangisidir?
// override

// SORU -4
// Bir sınıfın diğer sınıflar tarafından türetilmesi engellenmek isteniyorsa, aşağıdaki anahtar kelimelerden hangisi kullanılmalıdır?
// sealed

// SORU -5
// Interface isimlendirmesinin I ile başlamasıyla ilgili aşağıdakilerden hangisi doğru bilgidir?
// I ile başlaması programcılar arasındaki ortak dili destekler.

// SORU -6
// Temel sınıfın üyelerinden birinin sadece türetildiği sınıflardan erişilmesi isteniyorsa aşağıdaki erişim belirteçlerinden hangisi kullanılmalıdır?
// protected
#endregion

using System;
using DayOf_15_OOP.Exams;
using DayOf_15_OOP.Inheritance;
using DayOf_15_OOP.Interface;

namespace DayOf_15_OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism & Inheritancfe
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            // tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            // tohumluBitki.Solunum();
            tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalma();

            Kuslar kus = new Kuslar();

            // Interface

            #region Interface Basic Use
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();
            #endregion

            #region Interface Intermediate Use
            // Artık Hangi class'ı yarattığım ile ilginemiyorum. Log Manager bunun yerine bu işi kendi yapıyor
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
            #endregion

            #region  Interface Master Use
            Focus focus = new Focus();
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.StandartColor().ToString());
            Console.WriteLine(focus.WhellCount().ToString());


            Civis civis = new Civis();
            Console.WriteLine(civis.WhichBrand().ToString());
            Console.WriteLine(civis.StandartColor().ToString());
            Console.WriteLine(civis.WhellCount().ToString());
            #endregion

            #region Abstract Class Use
            Porshe porshe = new Porshe();
            Console.WriteLine(porshe.WhichBrand().ToString());
            Console.WriteLine(porshe.StandartColor().ToString());
            Console.WriteLine(porshe.WhellCount().ToString());

            Renault renault = new Renault();
            Console.WriteLine(renault.WhichBrand().ToString());
            Console.WriteLine(renault.StandartColor().ToString());
            Console.WriteLine(renault.WhellCount().ToString());
            #endregion
        }
    }
}