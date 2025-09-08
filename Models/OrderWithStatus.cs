using System;

namespace BlazingPizza.Models
{
    public class OrderWithStatus
    {
        public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
        public readonly static TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1);

        public Order Order { get; set; }
        public string StatusText { get; set; }
        public bool IsDelivered => StatusText == "Delivered";

        public static OrderWithStatus FromOrder(Order order)
        {
            var dispatchTime = order.CreatedTime.Add(PreparationDuration);
            string statusText;

            if (DateTime.Now < dispatchTime)
                statusText = "Preparing";
            else if (DateTime.Now < dispatchTime + DeliveryDuration)
                statusText = "Out for delivery";
            else
                statusText = "Delivered";

            return new OrderWithStatus { Order = order, StatusText = statusText };
        }
    }
}
