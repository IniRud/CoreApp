using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class StudentsModel : PageModel
    {
        public List<Student> Students {get; set;}
        public void OnGet()
        {
            Students = StudentManager.GetAll();
        }
    }
}
