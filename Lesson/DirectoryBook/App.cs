using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryBook.Controllers;
using DirectoryBook.Utils;
using DirectoryBook.Views;

namespace DirectoryBook
{
    public class App
    {
        

        public void Init()
        {
            PhoneView.Init();
        }

        public void Run()
        {
            int choice = 0;
            do
            {
                DummyMenu.ShowMainMenu();
                choice = DummyMenu.GetUserChoice();
                Console.WriteLine("==============================================");
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Çıkış Yapılıyor ! ....\n");
                        break;
                    case 1:
                        PhoneView.AddContactLogic();
                        break;
                    case 2:
                        PhoneView.DeleteContactLogic();
                        break;
                    case 3:
                        PhoneView.UpdatedContactLogic();
                        break;
                    case 4:
                        PhoneView.GetContactLogic();
                        break;
                    case 5:
                        PhoneView.SearchContactLogic();
                        break;
                    default:
                        Console.WriteLine("ERROR: Hatalı Bir Seçim Yaptınız!");
                        break;
                }
                DummyMenu.WaitForUserInput();
            } while(choice != 0);
        }
    }
}