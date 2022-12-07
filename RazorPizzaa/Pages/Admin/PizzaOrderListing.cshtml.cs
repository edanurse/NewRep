using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaa.Data;
using RazorPizzaa.Model;

namespace RazorPizzaa.Pages.Admin
{
    public class PizzaOrderListingModel : PageModel
    {
        public IEnumerable<PizzaOrder> PizzaOrders { get; set; }
        private readonly PizzaDbContext _db;
        public PizzaOrderListingModel(PizzaDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            PizzaOrders=_db.PizzaOrders;
            
        }
    }
}
