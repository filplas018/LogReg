using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Models;
using AccountsCreate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountsCreate.Pages
{
    public class LoginModel : PageModel
    {
        private AppDbContext _db { get; set; }
        public SessionStorage _ss;
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Pass { get; set; }
        [BindProperty]
        public User _us { get; set; }
        public List<User> Users { get; set; }
        public LoginModel(SessionStorage ss, AppDbContext db)
        {
            _ss = ss;
            _db = db;
        }
        public void OnGet()
        {
            //_us = _db.Users.Where(x => x.Name == );
        }
        public void OnPost()
        {
           // _us = _db.Users.Find(Name, Pass);
            
        }
    }
}
