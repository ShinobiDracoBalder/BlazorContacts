using BlazorContacts.Web.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorContacts.Web.Client.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;

        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteContact(int id)
        {
            await _httpClient.DeleteAsync($"api/Contacts/{id}");
        }

        public async Task<IEnumerable<Contacts>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Contacts>>($"api/Contacts");
        }

        public async Task<Contacts> GetDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<Contacts>($"api/Contacts/{id}");
        }

        public async Task SaveContact(Contacts contact)
        {
            if (contact.Id == 0)
                await _httpClient.PostAsJsonAsync<Contacts>($"api/Contacts", contact);
            else
                await _httpClient.PutAsJsonAsync<Contacts>($"api/Contacts/{contact.Id}", contact);
        }
    }
}
