using BlazorContacts.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContacts.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContacRepository _contactRepository;

        public ContactsController(IContacRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
    }
}
