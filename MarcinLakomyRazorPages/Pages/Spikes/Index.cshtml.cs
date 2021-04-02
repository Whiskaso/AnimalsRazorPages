using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarcinLakomyRazorPages.Pages.Spikes
{
    public class IndexModel : PageModel
    {
        public string mySampleModelData { get; set; }
        public void OnGet()
        {
            mySampleModelData = "Wartość przypisana w modelu.";
        }
    }
}
