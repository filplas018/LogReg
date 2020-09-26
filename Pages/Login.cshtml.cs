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
        [BindProperty]
        public List<User> Users { get; set; }
        public string message { get; set; }
        public LoginModel(SessionStorage ss, AppDbContext db)
        {
            _ss = ss;
            _db = db;
        }
        public void OnGet()
        {
            Users = _db.Users.ToList();
        }
        public IActionResult OnPost()
        {
            Users = _db.Users.ToList();
            foreach (var i in Users)
            {
                
                if (i.Name == Name && i.Password == Pass)
                {
                    _us.Name = Name;
                    _us.Password = Pass;
                    _ss.SaveUser(_us);
                    return RedirectToPage("./ProfilePage");
                }
            }
            return RedirectToPage("./Login");
            
        }
    }
}
