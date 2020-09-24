using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountsCreate.Pages
{
    public class LoginModel : PageModel
    {
        private AppDbContext _db { get; set; }
        [BindProperty]
        public User _us { get; set; }
        public void OnGet()
        {
            //_us = _db.Users.Where(x => x.Name == );
        }
       /* public IActionResult OnPost()
        {
            if (_db.Users.Contains(u) == true && _db.Users.Contains(v) == true)
            {
                return RedirectToPage("ProfilePage");
            }
            else return RedirectToPage("Login");
        }*/
    }
}
