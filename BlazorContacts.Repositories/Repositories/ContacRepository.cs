using BlazorContacts.Web.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorContacts.Repositories.Repositories
{
    public class ContacRepository : IContacRepository
    {
        public Task DeleteContact(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Contacts>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Contacts> GetDetails(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertContact(Contacts contact)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateContact(Contacts contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
