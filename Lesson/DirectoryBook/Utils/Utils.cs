using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryBook.Models;

namespace DirectoryBook.Utils
{
    static class DummyData
    {
        private static List<PhoneContact> dummyList = new List<PhoneContact> {
            new PhoneContact("Aaa1", "Aaa2", "0001"),
            new PhoneContact("Bbb1", "Bbb2", "0002"),
            new PhoneContact("Ccc1", "Ccc2", "0003"),
            new PhoneContact("Ddd1", "Ddd2", "0004"),
            new PhoneContact("Eee1", "Eee2", "0005")
        };

        public static List<PhoneContact> DummyList { get { return dummyList; } }
    }

    static class DummyMenu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine(
            "\n\t\tTelefon Rehber Uygulaması\n\n" +
            "\t1. Yeni bir numara kaydet \n" +
            "\t2. Sistemde bulunan bir numarayı sil \n" +
            "\t3. Sistemde bulunan bir numarayı güncelle\n" +
            "\t4. Tüm numaraları listele\n" +
            "\t5. Numara ara\n" +
            "\t0. Çıkış yap\n");
        }

        public static bool ConfirmAction()
        {
            while (true)
            {
                Console.Write("Devam etmek istiyor musunuz? (y/n)\n-> ");
                string choice = GetUserInput();
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                    return true;
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("İşlem iptal edildi...");
                    return false;
                }
                Console.WriteLine("Geçerli bir seçim yapın!");
            }
        }

        public static int GetUserChoice()
        {
            Console.Write("\tSeçiminiz !: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return -1;
            
            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 5)
                return choice;
            
            return -1;
        }

        public static string GetUserInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Geçerli bir giriş girin!\n----------------------------------------------");
                return "null";
            }
            return input;
        }

        public static void WaitForUserInput()
        {
            Console.Write("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}