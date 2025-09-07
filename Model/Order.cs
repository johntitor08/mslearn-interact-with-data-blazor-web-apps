using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza.Model
{
    public class Order
    {
        public int OrderId { get; set; }   // ✅ PK

        public string UserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        // Foreign key to Address
        public int AddressId { get; set; }
        public Address DeliveryAddress { get; set; }

        public List<Pizza> Pizzas { get; set; } = new();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());
        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
