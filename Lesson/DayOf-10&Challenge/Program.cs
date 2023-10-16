#region NOTES

#region Challenges - 1

// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

#endregion

#region Challenges - 2

// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

#endregion

#region Challenges - 3

// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

#endregion

#region Challenges - 4

// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

#endregion

#endregion

using System;

namespace DayOf_10_Challenges
{
    class Program
    {
        static void Main()
        {
            StateOne();
            StateTwo();
            StateThree();
            StateFour();
        }

        // STATE - 1
        public static void StateOne()
        {
            Console.Write("Pozitif bir sayı girin (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] sayilar = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"#{i + 1} sayıyı girin: ");
                    if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                    {
                        sayilar[i] = sayi;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen pozitif bir sayı girin.");
                        i--; // Kullanıcı geçersiz bir giriş yaptığı için döngüyü bir geri alalım.
                    }
                }
                Console.WriteLine("\nÇift sayılar:");
                foreach (int sayi in sayilar)
                {
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
            Console.ReadLine(); // Konsol penceresini kapatmak için bir tuşa basılmasını bekleyin.
        }

        // STATE - 2
        public static void StateTwo()
        {
            Console.Write("Pozitif bir sayı girin (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.Write("Pozitif bir sayı daha girin (m): ");
                if (int.TryParse(Console.ReadLine(), out int m) && m > 0)
                {
                    int[] sayilar = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"#{i + 1} sayıyı girin: ");
                        if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                        {
                            sayilar[i] = sayi;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen pozitif bir sayı girin.");
                            i--; // Kullanıcı geçersiz bir giriş yaptığı için döngüyü bir geri alalım.
                        }
                    }
                    Console.WriteLine($"\n{m}'e eşit veya tam bölünen sayılar:");
                    foreach (int sayi in sayilar)
                    {
                        if (m % sayi == 0)
                        {
                            Console.WriteLine(sayi);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }

            Console.ReadLine(); // Konsol penceresini kapatmak için bir tuşa basılmasını bekleyin.
        }

        // STATE - 3
        public static void StateThree()
        {
            Console.Write("Pozitif bir sayı girin (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                string[] kelimeler = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"#{i + 1} kelimeyi girin: ");
                    kelimeler[i] = Console.ReadLine();
                }

                Console.WriteLine("\nGirilen kelimeler sondan başa doğru:");

                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(kelimeler[i]);
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }

            Console.ReadLine(); // Konsol penceresini kapatmak için bir tuşa basılmasını bekleyin.
        }

        // STATE - 4
        public static void StateFour()
        {
            Console.Write("Bir cümle yazın: ");
            string cumle = Console.ReadLine();

            // Cümledeki kelime sayısını bulmak için boşluk karakterine göre böleriz.
            string[] kelimeler = cumle.Split(' ');

            // Cümledeki toplam kelime sayısı.
            int kelimeSayisi = kelimeler.Length;

            // Cümledeki toplam harf sayısı. Boşlukları ve noktalama işaretlerini çıkartırız.
            int harfSayisi = 0;
            foreach (string kelime in kelimeler)
            {
                harfSayisi += kelime.Length;
            }

            Console.WriteLine($"Cümledeki Toplam Kelime Sayısı: {kelimeSayisi}");
            Console.WriteLine($"Cümledeki Toplam Harf Sayısı: {harfSayisi}");

            Console.ReadLine(); // Konsol penceresini kapatmak için bir tuşa basılmasını bekleyin.
        }
    }
}