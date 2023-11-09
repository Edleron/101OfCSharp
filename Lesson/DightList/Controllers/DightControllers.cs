using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DightList.Models;

namespace DightList.Controllers
{
    public class DightControllers : IDightControllers
    {
        public List<DightCards> boardsList = new List<DightCards>();

        public void AddCard(DightCards dightCards)
        {
            boardsList.Add(dightCards);
        }

        public bool RemoveCard(string search)
        {
            var toDelete = boardsList.Where(x => x.Title == search).ToList();

            if (toDelete.Count > 0)
            {
                Console.WriteLine("Aşağıdaki kişiler silinecek:");
                foreach (var item in toDelete)
                {
                    Console.WriteLine($"{item.Title}");
                    boardsList.Remove(item);
                }
            }
            else
            {
                Console.WriteLine("Silinecek kişi bulunamadı.");
                return false;
            }

            return true;
        }

        public bool UpdateCard(string search)
        {
            throw new NotImplementedException();
        }

        public bool MoveCard(string search)
        {
            var toDelete = boardsList.Where(x => x.Title == search).ToList();

            if (toDelete.Count > 0)
            {
                Console.WriteLine("Aşağıdaki Kartlar Diğer Line'lara Taşınacaktır:");
                foreach (var item in toDelete)
                {
                    Console.WriteLine($"{item.Title}");

                    if (item.Grading == DightGrading.Todo)
                    {
                        item.Grading = DightGrading.InProgress;
                    }
                    else
                    {
                        item.Grading = DightGrading.Done;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                return false;
            }
        }

        public List<DightCards> ListBoard()
        {
            return boardsList.ToList();
        }

    }
}