using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DightList.Models;

namespace DightList.Controllers
{
    public interface IDightControllers
    {
        void AddCard(DightCards dightCards);

        bool RemoveCard(string search);

        bool UpdateCard(string search);

        bool MoveCard(string search);

        List<DightCards> ListBoard();
    }
}