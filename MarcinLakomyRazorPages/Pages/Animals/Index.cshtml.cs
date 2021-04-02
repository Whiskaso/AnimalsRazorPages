using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinLakomyRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarcinLakomyRazorPages.Pages.Animals
{
    public class IndexModel : PageModel
    {
        public List<Animal> Animals { get; set; }

        [TempData]
        public String message { get; set; }

        AnimalContext animalContext = new AnimalContext();
        public void OnGet()
        {
            Animals = animalContext.Animals.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var animal = animalContext.Animals.Find(id);
            animalContext.Animals.Remove(animal);
            animalContext.SaveChanges();
            message = "Usunięto zwierzątko o numerze id: " + id;
            return RedirectToPage();
        }
    }
}
