using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Forms
{
    public class CostumPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
