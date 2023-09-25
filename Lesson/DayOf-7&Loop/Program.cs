#region NOTES

#region For Döngüsü ?

// "for" döngüsü, belirli bir başlangıç değeri ile başlayarak belirli bir koşulu sağlayana veya belirli bir adımı tamamlayana kadar çalışır.

#endregion

#region Foreach Döngüsü ?

//  "foreach" döngüsü, koleksiyonlardaki veya dizilerdeki her öğeyi sırayla almak için kullanılır. 

#endregion

#region While Döngüsü ?

// "while" döngüsü, belirli bir koşul sağlandığı sürece çalışır.

#endregion

#region Do-while Döngüsü:

// "do-while" döngüsü, koşul sağlandığı sürece çalışır, ancak döngü en az bir kez çalıştırılır.

#endregion

#region Döngülerin Kırılması ve Devam Etmesi:

// Döngülerin içinde "break" ve "continue" ifadeleri kullanılarak döngülerin kırılması veya bir sonraki adıma geçilmesi sağlanabilir. "break", döngüyü tamamen sona erdirirken, "continue" bir sonraki adıma geçiş yapar.

#endregion

#endregion

using System;
using System.Collections.Generic;

namespace DayOf_7_Loop
{
    class Program
    {
        static void Main()
        {
            // for Döngüsü Örneği
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("for Döngü adımı: " + i);
            }

            // foreach Döngüsü Örneği
            List<string> meyveler = new List<string>();
            meyveler.Add("Elma");
            meyveler.Add("Armut");
            meyveler.Add("Çilek");
            meyveler.Add("Muz");
            foreach (string meyve in meyveler)
            {
                Console.WriteLine("Meyve: " + meyve);
            }

            // while Döngüsü Örneği
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine("while Döngü adımı: " + sayac);
                sayac++;
            }

            // do-while Döngüsü Örneği
            int sayac2 = 1;
            do
            {
                Console.WriteLine("do-while Döngü adımı: " + sayac2);
                sayac2++;
            } while (sayac2 <= 5);

            // Döngülerin Kırılması ve Devam Etmesi
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue; // 3. adımı atlar
                if (i == 4)
                    break; // 4. adımda döngüyü kırar
                Console.WriteLine("Döngü adımı: " + i);
            }
        }
    }
}