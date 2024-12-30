using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace MenuAndOrderLibrary.Tests
{
    public class OrderManagerTests
    {
        [Fact]
        public void CreateOrder_ShouldAddNewOrder()
        {
            var manager = new OrderManager();
            manager.CreateOrder(1);

            Assert.Equal("Очікує", manager.GetOrderStatus(1));
        }

        [Fact]
        public void AddDishToOrder_ShouldAddDishCorrectly()
        {
            var manager = new OrderManager();
            manager.CreateOrder(1);
            manager.AddDishToOrder(1, new Dish("Суп", 50.5m));

            var order = manager.GetOrder(1);

            Assert.Single(order.OrderedDishes);
        }

        [Fact]
        public void RemoveDishFromOrder_ShouldRemoveDishCorrectly()
        {
            var manager = new OrderManager();
            manager.CreateOrder(1);
            manager.AddDishToOrder(1, new Dish("Суп", 50.5m));
            manager.RemoveDishFromOrder(1, "Суп");

            var order = manager.GetOrder(1);

            Assert.Empty(order.OrderedDishes);
        }

        [Fact]
        public void RemoveDishFromOrder_ShouldThrowIfDishNotFound()
        {
            var manager = new OrderManager();
            manager.CreateOrder(1);

            Assert.Throws<InvalidOperationException>(() => manager.RemoveDishFromOrder(1, "Суп"));
        }
    }
}
