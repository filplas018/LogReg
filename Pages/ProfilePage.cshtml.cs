using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCreate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountsCreate.Pages
{
    public class ProfilePageModel : PageModel
    {
        public AppDbContext _db { get; set; }
        public User _us { get; set; }
        public void OnGet()
        {
        }
    }
}
