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


    }


}
