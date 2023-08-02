using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assest.Pages.model
{
    public class LoginModel
    {
        public object ViewData { get; private set; }

        public void OnGet()
        {
          
        }

        public IActionResult OnPost(string username, string password)
        {
           
            if (username == "Micky" && password == "123")
            {
              
                return RedirectToPage("/login");
            }
            else
            {
                
                 
                //ViewData ["ErrorMessage"] = "Invalid username or password.";
                return Page();
            }
        }

        private IActionResult Page()
        {
            throw new NotImplementedException();
        }

        private IActionResult RedirectToPage(string v)
        {
            throw new NotImplementedException();
        }
    }
}
