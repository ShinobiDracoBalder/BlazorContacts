using BlazorContacts.Web.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContacts.Web.Client.Services
{
    public class ContactService : IContactService
    {
        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contacts>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contacts> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveContact(Contacts contact)
        {
            throw new NotImplementedException();
        }
    }
}
