using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DightList.Models;

namespace DightList.Utils
{
    static class DummyData
    {
        private static List<DightPerson> dummyPersonList = new List<DightPerson> {
            new DightPerson(101, "Edleron", "Dgn", "Game Departman"),
            new DightPerson(102, "Wilkagul", "Dgn", "Art Departman"),
            new DightPerson(103, "Turltesa", "Dgn", "Frontend Departman"),
        };

        private static List<DightCards> dummyBoardList = new List<DightCards> {
            new DightCards("9001", "WoodenDucks", "Gereksinim Analizlerinin Belirlenmesi", dummyPersonList[0], DightSize.S, DightGrading.Todo),
            new DightCards("9002", "WoodenDucks", "Konsept Art'ın Çizilmesi", dummyPersonList[1], DightSize.XL, DightGrading.InProgress),
            new DightCards("9003", "WoodenDucks", "Menu Bar'ın Kodlanması", dummyPersonList[2], DightSize.L, DightGrading.Todo),
        };

        public static List<DightPerson> DummyPersonList { get { return dummyPersonList; } }
        public static List<DightCards> DummyBoardList { get { return dummyBoardList; } }
    }

    static class DummyMenu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine(
            "\n\t\tDight Todo List\n\n" +
            "\t1. Board Listelemek \n" +
            "\t2. Board'a Kart Ekle \n" +
            "\t3. Borad'dan Kart Sil\n" +
            "\t4. Kart Taşı\n" +
            "\t0. Çıkış yap\n");
        }

        public static int GetUserChoice()
        {
            Console.Write("\tSeçiminiz !: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return -1;
            
            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 4)
                return choice;
            
            return -1;
        }

        public static void ShowTwoAccensMenu()
        {
            Console.WriteLine(
            "\n\t\tCard Remove\n\n" +
            "\t1. Silmeyi sonlandırmak için \n" +
            "\t2. Yeniden denemek için \n");
        }

        public static int GetUserTwoChoice()
        {
            Console.Write("\tSeçiminiz !: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return -1;
            
            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= 2)
                return choice;
            
            return -1;
        }

        public static void WaitForUserInput()
        {
            Console.Write("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadLine();
            Console.Clear();
        }

        public static string GetStringUserInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Geçerli bir giriş girin!\n----------------------------------------------");
                return null;
            }
            return input;
        }

        public static int GetIntUserInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Geçerli bir giriş girin!\n----------------------------------------------");
                return -1;
            }
            bool check = IsInteger(input);

            if (check)
            {
                return Convert.ToInt32(input) ;
            } else {
                return -1;
            }
        }


        public static bool IsInteger(string input)
        {
            if (int.TryParse(input, out _))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Geçerli bir tamsayı girin!\n----------------------------------------------");
                return false;
            }
        }
    }
}