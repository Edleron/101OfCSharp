using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DightList.Utils;
using DightList.Views;

namespace DightList
{
    public class App
    {
        public void Init()
        {
            DightViews.Init();
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
                        DightViews.GetBoardTodoLogic();
                        DightViews.GetBoardInProgressLogic();
                        DightViews.GetBoardDoneLogic();
                        break;
                    case 2:
                        DightViews.AddCardLogic();
                        break;
                    case 3:
                         DightViews.RemoveCardLogic();
                        break;
                    case 4:
                        DightViews.MoveCardogic();
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