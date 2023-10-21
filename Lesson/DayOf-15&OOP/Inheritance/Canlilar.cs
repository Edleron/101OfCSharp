using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOf_15_OOP
{
    public class Canlilar
    // public sealed class Canlilar // -> Kodun tamamı hata verir, Çünkü sealed işaretli class'lar kalıtım veremez.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir. !");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar. !");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar. !");
        }

        public virtual void UyaranlaraTepki(){
             Console.WriteLine("Canlılar Uyaranlara Tepki Verir. !");
        }
    }
}