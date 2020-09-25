using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Models;
using AccountsCreate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AccountsCreate.Pages
{
    public class IndexModel : PageModel
    {
        public SessionStorage _ss { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private AppDbContext _db { get; set; }
        [BindProperty]
        public string message { get; set; }
        
        
        [BindProperty]
        public User _us { get; set; }
        [BindProperty]
        public string ControlPass { get; set; }
        [BindProperty]
        public List<User> Users { get; set; }
        public IndexModel(ILogger<IndexModel> logger, AppDbContext db, SessionStorage ss)
        {
            _db = db;
            _logger = logger;
            _ss = ss;
        }


        public void OnGet()
        {
            Users = _db.Users.ToList();
            if (_ss.GetMess() != null)
            {
                message = _ss.GetMess();
            }
            else
                message = "Zaregistruj se nebo se přihlaš";
            
        }
        public IActionResult OnPost()
        {
            if(_us.Password == ControlPass )
            {
            _db.Users.Add(new User { Name = _us.Name, Password = _us.Password });
            _db.SaveChanges();
            return RedirectToPage("NewUser");
        }
            else
            {
                message = "Hesla se neshodují!";
                _ss.SetMess(message);
                return RedirectToPage("Index");
            }          
        }

    }
}
