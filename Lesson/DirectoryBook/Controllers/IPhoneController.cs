using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using DirectoryBook.Models;

namespace DirectoryBook.Controllers
{
    public interface IPhoneController
    {
        void AddContact(PhoneContact phoneContact);

        bool RemoveContact(string name);

        bool UpdateContact(string name);

        List<PhoneContact> GetContacts();

        List<PhoneContact> SearchContact(string searchType, string searchData);
    }
}