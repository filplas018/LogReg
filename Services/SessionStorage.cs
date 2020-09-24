using AccountsCreate.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Helpers;

namespace AccountsCreate.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        const string KEY = "key";
        public User user { get; set; }
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        public void SaveUser(User userr)
        {
            _session.Set<User>(KEY, userr);
        }
        public User GetUser()
        {
            return _session.Get<User>(KEY);
        }
    }
}
