using BlazorContacts.Web.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorContacts.Web.Client.Services
{
    public interface IContactService
    {
        Task SaveContact(Contacts contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contacts>> GetAll();
        Task<Contacts> GetDetails(int id);
    }
}
