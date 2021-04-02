using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinLakomyRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarcinLakomyRazorPages.Pages.Animals
{
    public class CreateModel : PageModel
    {
        public Animal animal { get; set; }
        AnimalContext AnimalContext = new AnimalContext();
        public void OnGet()
        {
        }

        [TempData]
        public String message { get; set; }

        public IActionResult OnPost(Animal animal)
        {
            AnimalContext.Animals.Add(animal);
            AnimalContext.SaveChanges();
            message = "Dodano zwierzątko";
            return RedirectToPage("Index");
        }
    }
}
