using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryBook.Controllers;
using DirectoryBook.Models;
using DirectoryBook.Utils;

namespace DirectoryBook.Views
{
    static class PhoneView
    {
        static PhoneContoller phoneController;

        public static void Init()
        {
            phoneController = new PhoneContoller();
            phoneController.phoneBook.AddRange(DummyData.DummyList);
        }

        public static void AddContactLogic()
        {
            string name, surname, phone;

            do
            {
                Console.Write("İsminizi Girin: ");
                name = DummyMenu.GetUserInput();
            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("Soy isminizi Girin: ");
                surname = DummyMenu.GetUserInput();
            } while (string.IsNullOrEmpty(surname));

            do
            {
                Console.Write("Numaranızı Giriniz: ");
                phone = DummyMenu.GetUserInput();
            } while (string.IsNullOrEmpty(phone));

            PhoneContact phoneContact = new PhoneContact(name, surname, phone);
            phoneController.AddContact(phoneContact);

            Console.WriteLine("İşlem Başarılı !");
        }


        public static void DeleteContactLogic()
        {
            while (true)
            {
                Console.Write("Numaranın adını veya soyadını girin: ");
                string searchTerm = DummyMenu.GetUserInput();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    Console.WriteLine("Geçerli bir değer girmediniz.");
                    if (!DummyMenu.ConfirmAction())
                        return;
                }
                else
                {
                    bool status = phoneController.RemoveContact(searchTerm);

                    if (!status)
                    {
                        Console.WriteLine("Bu verilerle herhangi bir işlem yapılamamaktadır.");
                        return;
                    }
                    else {
                        Console.WriteLine("işlem başarıyla gerçekleşmiştir.");
                        return;
                    }
                }
            }
        }


        public static void UpdatedContactLogic()
        {
            while (true)
            {
                Console.Write("Numaranın adını veya soyadını girin: ");
                string searchTerm = DummyMenu.GetUserInput();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    Console.WriteLine("Geçerli bir değer girmediniz.");
                    if (!DummyMenu.ConfirmAction())
                        return;
                }
                else
                {
                    bool status = phoneController.UpdateContact(searchTerm);

                    if (!status)
                    {
                        Console.WriteLine("Bu verilerle eşleşen herhangi bir kayıt bulunmamaktadır.");
                        return;
                    }
                    else {
                        Console.WriteLine("Başarıyla güncellendi!");
                        return;
                    }
                }
            }
        }


        public static void GetContactLogic()
        {
            var allContacts = phoneController.GetContacts();

            Console.WriteLine($"\tKayıtlı ({allContacts.Count} Numaralar)\n----------------------------------------------");

            if (allContacts == null || allContacts.Count == 0)
            {
                Console.WriteLine("Hiç Kayıt Bulunamadı!");
                return;
            }           

            foreach (var rec in allContacts)
            {
                Console.WriteLine($"\tAd\t: {rec.FirstName}");
                Console.WriteLine($"\tSoyad\t: {rec.LastName}");
                Console.WriteLine($"\tTelefon\t: {rec.PhoneNumber}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        public static void SearchContactLogic()
        {
            while (true)
            {
                string choice;
                do
                {
                    Console.Write("\t(1) Ad/soyad ile arama\n\t(2) Numara ile ara\n-> ");
                    choice = DummyMenu.GetUserInput();
                } while (choice.CompareTo("null") == 0);
                Console.WriteLine();

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Geçerli bir seçim yapın!\n----------------------------------------------");
                    continue;
                }

                Console.Write("Arama verilerini girin: ");
                string searchData = DummyMenu.GetUserInput();
                var searchResults = phoneController.SearchContact(choice, searchData);

                Console.WriteLine("----------------------------------------------");

                if (searchResults.Count == 0)
                    Console.Write("Bu verilerle eşleşen kayıt bulunamadı! ");
                
                if (!DummyMenu.ConfirmAction())
                    return;
            }
        }
    }
}