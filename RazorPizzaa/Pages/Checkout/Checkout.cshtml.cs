using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaa.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice{ get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name)) {
                Name = "Custom Pizza";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle)) 
            {
                ImageTitle = "Create";
            }
        }
    }
}
