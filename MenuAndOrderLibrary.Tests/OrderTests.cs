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
            order.OrderedDishes.Add(new Dish("���", 50.5m));
            order.OrderedDishes.Add(new Dish("�����", 30.25m));

            var total = order.CalculateTotal();

            Assert.Equal(80.75m, total);
        }
        [Fact]
        public void UpdateOrderStatus_ShouldUpdateStatusCorrectly()
        {
            var order = new Order(1);
            order.UpdateOrderStatus("��������");
            order.UpdateOrderStatus("������");

            Assert.Equal("������", order.Status);
        }

        [Fact]
        public void UpdateOrderStatus_ShouldThrowForInvalidStatusChange()
        {
            var order = new Order(1);

            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("������"));
        }
    }

}