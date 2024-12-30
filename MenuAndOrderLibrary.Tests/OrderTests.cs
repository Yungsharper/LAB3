using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace MenuAndOrderLibrary.Tests
{
    public class OrderTests
    {
        [Fact]
        public void CalculateTotal_ShouldReturnCorrectTotal()
        {
            var order = new Order(1);
            order.OrderedDishes.Add(new Dish("Суп", 50.5m));
            order.OrderedDishes.Add(new Dish("Салат", 30.25m));

            var total = order.CalculateTotal();

            Assert.Equal(80.75m, total);
        }

    }

   