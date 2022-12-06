using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
         
            PizzaPrice += Pizza.Sauce ? 5 : 0;
            PizzaPrice += Pizza.Cheese ? 5 : 0;
            PizzaPrice += Pizza.Peporoni ? 5 : 0;
            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name,PizzaPrice });
        }
    }
}
