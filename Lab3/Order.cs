using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Order
    {
        public int OrderId { get; private set; } // Унікальний ідентифікатор замовлення
        public List<Dish> OrderedDishes { get; private set; } // Список страв у замовленні
        public string Status { get; private set; } // Статус замовлення ("Очікує", "Готується", "Готово")

        // Конструктор замовлення
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderedDishes = new List<Dish>();
            Status = "Очікує";
        }
        // Метод для оновлення статусу замовлення
        public void UpdateOrderStatus(string newStatus)
        {
            if ((Status == "Очікує" && newStatus == "Готується") ||
                (Status == "Готується" && newStatus == "Готово"))
            {
                Status = newStatus;
            }
            else
            {
                throw new InvalidOperationException("Неправильна послідовність оновлення статусу.");
            }
        }

        // Метод для обчислення загальної вартості замовлення
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var dish in OrderedDishes)
            {
                total += dish.Price;
            }
            return total;
        }

    }


}
