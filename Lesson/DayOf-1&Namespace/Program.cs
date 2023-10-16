#region NOTES
// -> dotnet new console                    --> --> Terminalde yeni console projesi yaratır.
// -> csproj uzantılı dosya,                --> --> yaratılan projenin özellikleri gösterir.
// -> csproj içerisindeki RootNamespace     --> --> DayOf_1_Namespace'dir, yani proje bu namespace üzerinde inşa edilir.
// -> Main metodu                           --> --> Bir nesne örneği yaratmadan C# bu gövdeden kodu başlatır. Ve geriye hiç bir şey (void) döndürmez. Aynı zamanda komut satırından parametreler alır.

// DESCRIPTION -> C# programlama dilinde "namespace," bir kod dosyasının veya proje içindeki kodun belirli bir kapsam veya isim alanını temsil eden bir kavramdır. 
//             -> Bu, kodun düzenli ve yönetilebilir olmasını sağlar çünkü aynı isimdeki sınıflar veya fonksiyonlar farklı isim alanlarında birbirinden bağımsız olarak tanımlanabilir ve kullanılabilir

// VS CODE CONFIGURATION -> Run and debug bölümünden create diyip, .vs altında config ayarlarını çalıştırıyoruz. Aynı zamanda artık yukarıda yeşil kod derle düğme aktif hale geliyor.

// IMPORTANT  -> launch.json içerisinde "program" sekmesi bölümündeki dll önemlidir.
// IMPORTANT  -> launch.json içerisinde "console" sekmesi bölümündeki internalConsole -> integratedTerminal ile değiştirilmiştir, Bu vsCode içerisindeki terminal bölümünü kullanmamıza olanak sağlar.
#endregion

using System;

namespace DayOf_1_Namespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Please Names Enter:");
            string name = Console.ReadLine();

            Console.WriteLine("Please Surname Enter");
            string surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname);
        }
    }
}