using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Dish> OrderedDishes { get; set; } = new();
        public string Status { get; set; } = "Очікує";

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public decimal CalculateTotal()
        {
            return OrderedDishes.Sum(d => d.Price);
        }

        public void UpdateOrderStatus(string newStatus)
        {
            var allowedTransitions = new Dictionary<string, string[]>
            {
                { "Очікує", new[] { "Готується" } },
                { "Готується", new[] { "Готово" } }
            };

            if (allowedTransitions.ContainsKey(Status) && allowedTransitions[Status].Contains(newStatus))
            {
                Status = newStatus;
            }
        }
    }
}
