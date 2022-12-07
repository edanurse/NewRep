using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Data;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice{ get; set; }
        public string ImageTitle { get; set; }
        private PizzaDbContext _db;
       
    
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
