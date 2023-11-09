using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DightList.Models
{
    public class DightPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }

        public DightPerson(int id, string firstName, string lastName, string departman)
        {
            Id          = id;
            FirstName   = firstName;
            LastName    = lastName;
            Departman   = departman;
        }
    }
}