using BlazorContacts.Web.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorContacts.Repositories.Repositories
{
    public interface IContacRepository
    {
        Task<bool> InsertContact(Contacts contact);
        Task<bool> UpdateContact(Contacts contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contacts>> GetAll();
        Task<Contacts> GetDetails(int id);
    }
}
