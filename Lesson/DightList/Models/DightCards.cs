using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DightList.Models
{
    public class DightCards
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DightPerson Person { get; set; }
        public DightSize Size { get; set; }
        public DightGrading Grading { get; set; }

        public DightCards(string id, string title, string contents, DightPerson person, DightSize size, DightGrading grading)
        {
            Id          = id;
            Title       = title;
            Contents    = contents;
            Person      = person;
            Size        = size;
            Grading     = grading;
        }
    }
}