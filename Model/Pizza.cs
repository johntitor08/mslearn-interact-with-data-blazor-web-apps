using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza.Model
{
    public class Pizza
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int Id { get; set; }   // ✅ PK

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int SpecialId { get; set; }
        public PizzaSpecial Special { get; set; }

        public int Size { get; set; } = DefaultSize;

        public List<PizzaTopping> Toppings { get; set; } = new();

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            var total = GetBasePrice();
            if (Toppings != null)
            {
                total += Toppings.Sum(t => t.Topping.Price);
            }
            return total;
        }

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
