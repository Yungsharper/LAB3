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
        [Fact]
        public void UpdateOrderStatus_ShouldUpdateStatusCorrectly()
        {
            var order = new Order(1);
            order.UpdateOrderStatus("Готується");
            order.UpdateOrderStatus("Готово");

            Assert.Equal("Готово", order.Status);
        }

        [Fact]
        
        public void UpdateOrderStatus_ShouldThrowForInvalidStatusChange()
        {
            var order = new Order(1);

            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("Готово"));


            // 2. Правильна зміна статусу на "Готується"
            order.UpdateOrderStatus("Готується");

            // 3. Спроба повернутися назад на "Очікує" (недопустимо)
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("Очікує"));

            // 4. Спроба змінити статус на недопустимий (наприклад, "Скасовано", якщо його немає в списку)
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("Скасовано"));

            // 5. Зміна статусу на "Готово" (завершення замовлення)
            order.UpdateOrderStatus("Готово");

            // 6. Спроба змінити статус після завершення
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("Готується"));
        }
    }

}