using Lab3;
using System;

namespace Docker
{
    class Program
    {
        
       

        static void Main(string[] args)
        {
            var menu = new List<Dish>
        {
            new Dish("Pizza", 8.99m),
            new Dish("Pasta", 7.99m),
            new Dish("Salad", 4.99m)
        };

            var order = new Order(1); // Створюємо замовлення з ID = 1

            // Додаємо кілька страв до замовлення
            order.OrderedDishes.Add(menu[0]); // Pizza
            order.OrderedDishes.Add(menu[1]); // Pasta

            // Виведення загальної вартості замовлення
            Console.WriteLine($"Загальна вартість замовлення {order.OrderId}: {order.CalculateTotal()}");

            // Оновлюємо статус замовлення
            try
            {
                order.UpdateOrderStatus("Готується"); // Оновлюємо статус на "Готується"
                Console.WriteLine($"Статус замовлення {order.OrderId}: {order.Status}");

                order.UpdateOrderStatus("Готово"); // Оновлюємо статус на "Готово"
                Console.WriteLine($"Статус замовлення {order.OrderId}: {order.Status}");

                order.UpdateOrderStatus("Готово"); // Оновлюємо статус на "Готово"
                Console.WriteLine($"Статус замовлення {order.OrderId}: {order.Status}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}