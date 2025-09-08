using System.Collections.Generic;

namespace BlazingPizza.Models
{
    public class Topping
    {
        public int Id { get; set; }   // ✅ PK
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<PizzaTopping> PizzaToppings { get; set; } = new List<PizzaTopping>();

        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
