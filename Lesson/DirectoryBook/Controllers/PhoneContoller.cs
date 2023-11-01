using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryBook.Models;
using DirectoryBook.Utils;

namespace DirectoryBook.Controllers
{
    public class PhoneContoller : IPhoneController
    {
        public List<PhoneContact> phoneBook = new List<PhoneContact>();

        public void AddContact(PhoneContact phoneContact)
        {
            phoneBook.Add(phoneContact);
        }

        public bool RemoveContact(string seach)
        {
            var delete = phoneBook.FirstOrDefault(x => x.FirstName == seach || x.LastName == seach);

            if (delete != null)
            {
                if (Utils.DummyMenu.ConfirmAction())
                {
                    phoneBook.Remove(delete);
                    return true;
                }                
                return false;
            }
            
            return false;
        }
        public bool UpdateContact(string search)
        {
            var contact = phoneBook.FirstOrDefault(c => c.FirstName.Equals(search, StringComparison.OrdinalIgnoreCase)
                                                          || c.LastName.Equals(search, StringComparison.OrdinalIgnoreCase)
                                                          || c.PhoneNumber.Equals(search, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                Console.WriteLine("Bir kayıt bulundu!");
                if (DummyMenu.ConfirmAction())
                {
                    Console.Write("Yeni adı girin: ");
                    contact.FirstName = DummyMenu.GetUserInput();
                    Console.Write("Yeni soyadınızı girin: ");
                    contact.LastName = DummyMenu.GetUserInput();
                    Console.Write("Yeni numarayı girin: ");
                    contact.PhoneNumber = DummyMenu.GetUserInput();
                    
                    return true;                   
                }          
                return false;      
            }
            else
            {
                return false;      
            }

        }

        public List<PhoneContact> GetContacts()
        {
           return phoneBook.ToList();
        }        

        public List<PhoneContact> SearchContact(string searchType, string searchData)
        {
            List<PhoneContact> searchResults = new List<PhoneContact>();
            
            if (searchType == "1")
            {
                searchResults = phoneBook
                    .Where(rec => rec.FirstName.ToLower() == searchData.ToLower() || rec.LastName.ToLower() == searchData.ToLower())
                    .ToList();
            }
            else if (searchType == "2")
            {
                searchResults = phoneBook
                    .Where(rec => rec.PhoneNumber.ToLower() == searchData.ToLower())
                    .ToList();
            }

            foreach (var result in searchResults)
            {
                Console.WriteLine("Name\t: " + result.FirstName);
                Console.WriteLine("Surname\t: " + result.LastName);
                Console.WriteLine("Number\t: " + result.PhoneNumber);
            }

            return searchResults;
        }

        
    }
}