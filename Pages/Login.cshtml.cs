using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Helpers;
using AccountsCreate.Models;
using AccountsCreate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountsCreate.Pages
{
    public class LoginModel : PageModel
    {
        private AppDbContext _db { get; set; }

        private readonly SessionStorage _ss;
        [BindProperty]
        public User _us { get; set; }
        public LoginModel(SessionStorage ss, AppDbContext db)
        {
            _ss = ss;
            _db = db;
        }
        public void OnGet()
        {
            //_us = _db.Users.Where(x => x.Name == );
        }
       public IActionResult OnPost()
        {//TODO
            if ()
            {

            }
            else
            {
                return RedirectToPage("Login");
            }
        }
    }
}
