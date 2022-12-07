using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Data;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankyouModel : PageModel
    { 
        public string Name{ get; set; }
        public float PizzaPrice { get; set; }
    
        private readonly PizzaDbContext _db;
        public ThankyouModel(PizzaDbContext db)
        {
            _db=db;
        }
        public void OnGet()
        {
            PizzaOrder pizzaOrder=new PizzaOrder();
            pizzaOrder.PizzaName = Name;
            pizzaOrder.Price = PizzaPrice;
            _db.PizzaOrders.Add(pizzaOrder);
            _db.SaveChanges();
        }
    }
}
