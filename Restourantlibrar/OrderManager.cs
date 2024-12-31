using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab3
{
    public class OrderManager
    {
        private readonly Dictionary<int, Order> _orders; // Зберігає всі замовлення

        // Конструктор менеджера замовлень
        public OrderManager()
        {
            _orders = new Dictionary<int, Order>();
        }

        public int CreateOrder()
        {
            var orderId = _orders.Count + 1; // Генеруємо новий ID замовлення
            var order = new Order(orderId);
            _orders.Add(orderId, order);
            return orderId; // Повертаємо ID створеного замовлення
        }

        // Метод для створення нового замовлення
        public void CreateOrder(int orderId)
        {
            if (_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Замовлення з таким ID вже існує.");
            }
            _orders[orderId] = new Order(orderId);
        }

        // Метод для додавання страви до замовлення
        public void AddDishToOrder(int orderId, Dish dish)
        {
            if (!_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Замовлення з таким ID не знайдено.");
            }
            _orders[orderId].OrderedDishes.Add(dish);
        }

        // Метод для видалення страви із замовлення
        public void RemoveDishFromOrder(int orderId, string dishName)
        {
            if (!_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Замовлення з таким ID не знайдено.");
            }

            var order = _orders[orderId];
            var dish = order.OrderedDishes.Find(d => d.Name == dishName);
            if (dish == null)
            {
                throw new InvalidOperationException("Страва з такою назвою не знайдена в замовленні.");
            }

            order.OrderedDishes.Remove(dish);
        }

        // Метод для отримання статусу замовлення
        public string GetOrderStatus(int orderId)
        {
            if (!_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Замовлення з таким ID не знайдено.");
            }
            return _orders[orderId].Status;
        }

        // Метод для отримання замовлення
        public Order GetOrder(int orderId)
        {
            if (!_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Замовлення з таким ID не знайдено.");
            }
            return _orders[orderId];
        }
    }
}
