using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class CreateModel : PageModel
    {
        public Student Student { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var s = new Student
            {
                FirstName = Request.Form["FirstName"],
                LastName = Request.Form["LastName"],
                Phone = Request.Form["Phone"]
            };
            StudentManager.Add(s);

            return RedirectToPage("Students");
        }
    }
}
