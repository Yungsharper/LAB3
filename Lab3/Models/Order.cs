using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Order
    {
        public int OrderId { get; }
        public List<Dish> OrderedDishes { get; }
        public string Status { get; private set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderedDishes = new List<Dish>();
            Status = "Очікує";
        }

        public void AddDish(Dish dish)
        {
            OrderedDishes.Add(dish);
        }

        public void RemoveDish(string dishName)
        {
            var dishToRemove = OrderedDishes.FirstOrDefault(d => d.Name == dishName);
            if (dishToRemove != null)
            {
                OrderedDishes.Remove(dishToRemove);
            }
        }

        public string GetStatus()
        {
            return Status;
        }

        public void UpdateStatus(string newStatus)
        {
            if (newStatus == "Очікує" || newStatus == "Готується" || newStatus == "Готово")
            {
                Status = newStatus;
            }
        }
    }
}
