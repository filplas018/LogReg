using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AccountsCreate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string message = ":D";
        private AppDbContext _db { get; set; }
        [BindProperty]
        public User _us { get; set; }
        [BindProperty]
        public string ControlPass { get; set; }
        [BindProperty]
        public List<User> Users { get; set; }
        public IndexModel(ILogger<IndexModel> logger, AppDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        public void OnGet()
        {
            Users = _db.Users.ToList();
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
                return RedirectToPage("Index");
            }          
        }

    }
}
