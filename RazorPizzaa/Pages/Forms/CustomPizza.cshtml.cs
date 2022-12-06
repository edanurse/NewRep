using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        public float FinalPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            FinalPrice = Pizza.BasePrice;
            FinalPrice += Pizza.Sauce ? 5 : 0;
            FinalPrice += Pizza.Cheese ? 5 : 0;
            FinalPrice += Pizza.Peporoni ? 5 : 0;
            FinalPrice += Pizza.Mushroom ? 5 : 0;
            FinalPrice += Pizza.Tuna ? 5 : 0;
            FinalPrice += Pizza.Pineapple? 5 : 0;
            FinalPrice += Pizza.Beef ? 10 : 0;
                    return RedirectToPage("/Checkout/Checkout", new { Pizza.Name,FinalPrice=Pizza.FinalPrice, });
        }
    }
}
