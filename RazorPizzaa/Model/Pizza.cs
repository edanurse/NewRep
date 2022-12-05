namespace RazorPizzaa.Model
{
    public class Pizza
    {
        public string Name { get; set; }
        public string ImageTitle { get; set; }
        public float BasePrice { get; set; } = 10;
        public bool Sauce{ get; set; }
        public bool Cheese { get; set; }
        public bool Peporoni { get; set; }
    }
}
