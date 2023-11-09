using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DightList.Controllers;
using DightList.Models;
using DightList.Utils;

namespace DightList.Views
{
    static class DightViews
    {
        static DightControllers dightControllers;

        public static void Init()
        {
            dightControllers = new DightControllers();
            dightControllers.boardsList.AddRange(DummyData.DummyBoardList);
        }

        public static void AddCardLogic()
        {
            string title, description;
            int sizeId = -1;
            int personId = -1;

            do
            {
                Console.Write("Başlık Giriniz: ");
                title = DummyMenu.GetStringUserInput();
            } while (string.IsNullOrEmpty(title));

            do
            {
                Console.Write("Açıklama Giriniz: ");
                description = DummyMenu.GetStringUserInput();
            } while (string.IsNullOrEmpty(description));

            do
            {
                Console.Write("Lütfen Büyüklük id Giriniz: ");
                var dummySizeId = DummyMenu.GetIntUserInput();

                if (dummySizeId == -1)
                {
                    sizeId = -1; // Kullanıcı -1 girdiyse çıkış yap
                }
                else
                {
                    if (dummySizeId > 0 && dummySizeId < 5)
                    {
                        sizeId = dummySizeId;
                    }
                    else
                    {
                        sizeId = -1;
                        Console.WriteLine("Lütfen Size ID'sini Doğru Giriniz");
                    }
                }
            } while (sizeId == -1);

            do
            {
                Console.Write("Lütfen Yetkili Kişi id Giriniz: ");
                var dummyPersonId = DummyMenu.GetIntUserInput();

                if (dummyPersonId == -1)
                {
                    personId = -1; // Kullanıcı -1 girdiyse çıkış yap
                }
                else
                {
                    var personX = DummyData.DummyPersonList.FirstOrDefault(p => p.Id == dummyPersonId);

                    if (personX != null)
                    {
                        personId = dummyPersonId;
                    }
                    else
                    {
                        personId = -1;
                        Console.WriteLine("Lütfen Kişi ID'sini Doğru Giriniz");
                    }
                }
            } while (personId == -1);

            DightPerson ttt = DummyData.DummyPersonList.FirstOrDefault(p => p.Id == personId);
            DightSize xxx = (DightSize)Enum.Parse(typeof(DightSize), sizeId.ToString());

            DightCards dightCards = new DightCards("1001", title, description, ttt, xxx, DightGrading.Todo);

            dightControllers.AddCard(dightCards);

            Console.WriteLine("İşlem Başarılı.");
        }


        public static void RemoveCardLogic()
        {
            string title;

            Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. ");
            do
            {
                Console.Write("Başlık Giriniz: ");
                title = DummyMenu.GetStringUserInput();
            } while (string.IsNullOrEmpty(title));

            bool check = dightControllers.RemoveCard(title);

            if (!check)
            {
                DummyMenu.ShowTwoAccensMenu();
                int choice = DummyMenu.GetUserTwoChoice();
                
                switch (choice)
                {
                    case 1:
                        
                        break;
                    case 2:
                        RemoveCardLogic();
                        break;

                }
            }
        }

        public static void UpdatedCardLogic()
        {

        }

        public static void MoveCardogic()
        {
            string title;

            Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. ");
            do
            {
                Console.Write("Başlık Giriniz: ");
                title = DummyMenu.GetStringUserInput();
            } while (string.IsNullOrEmpty(title));

            bool check = dightControllers.MoveCard(title);

            if (!check)
            {
                DummyMenu.ShowTwoAccensMenu();
                int choice = DummyMenu.GetUserTwoChoice();
                
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        MoveCardogic();
                        break;

                }
            }
        }

        public static void GetBoardTodoLogic()
        {
           GetBoardListLogic("TODO LINE", Models.DightGrading.Todo);
        }


        public static void GetBoardInProgressLogic()
        {
           GetBoardListLogic("INPROGRESS LINE", Models.DightGrading.InProgress);
        }

        public static void GetBoardDoneLogic()
        {
            GetBoardListLogic("DONE LINE", Models.DightGrading.Done);
        }

        private static void GetBoardListLogic(string title, Models.DightGrading contidion){
            var allCards = dightControllers.ListBoard();
            if (allCards == null || !allCards.Any())
            {
                Console.WriteLine("Hiç Kayıt Bulunamadı!");
                return;
            }

            Console.WriteLine("\t\t" + title);
            Console.WriteLine("************************");

            var todoCards = allCards.Where(card => card.Grading == contidion);

            foreach (var card in todoCards)
            {
                Console.WriteLine($"\tBaşlık        \t:   {card.Title}");
                Console.WriteLine($"\tİçerik        \t:   {card.Contents}");
                Console.WriteLine($"\tAtanan Kişi   \t:   {card.Person.FirstName}");
                Console.WriteLine($"\tBüyüklük      \t:   {card.Size}");

                if (card != todoCards.Last())
                    Console.WriteLine($"\t-");
                else
                    Console.WriteLine($"\n");
            }
        }
    }
}