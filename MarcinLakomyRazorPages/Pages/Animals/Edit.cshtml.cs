using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinLakomyRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarcinLakomyRazorPages.Pages.Animals
{
    public class EditModel : PageModel
    {
        private AnimalContext AnimalContext = new AnimalContext();

        [TempData]
        public String message { get; set; }

        [BindProperty]
        public Animal animal { get; set; }

        public void OnGet(int id)
        {
            animal = AnimalContext.Animals.Find(id);
        }

        public IActionResult OnPost()
        {
            AnimalContext.Animals.Update(animal);
            AnimalContext.SaveChanges();
            message = "The animal id: " + animal.AnimalID + " was updated.";
            return RedirectToPage("index");
        }
    }
}
