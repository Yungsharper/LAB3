using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace MenuAndOrderLibrary.Tests
{
    public class MenuTests
    {
        // Тест перевіряє, чи можна додати страву до меню
        [Fact]
        public void AddDish_ShouldAddDishToMenu()
        {
            var menu = new Menu();
            var dish = new Dish("Pizza", 12.5m);

            menu.AddDish(dish);

            // Перевіряємо, що страва успішно додана
            Assert.Single(menu.GetDishes());
        }

        // Тест перевіряє, чи можна видалити страву з меню
        [Fact]
        public void RemoveDish_ShouldRemoveDishFromMenu()
        {
            var menu = new Menu();
            var dish = new Dish("Pasta", 8.5m);

            menu.AddDish(dish);
            menu.RemoveDish("Pasta");

            // Перевіряємо, що страва успішно видалена
            Assert.Empty(menu.GetDishes());
        }

        // Тест перевіряє, чи можна отримати список усіх страв
        [Fact]
        public void GetDishes_ShouldReturnAllDishes()
        {
            var menu = new Menu();
            menu.AddDish(new Dish("Salad", 5.0m));
            menu.AddDish(new Dish("Soup", 7.0m));

            var dishes = menu.GetDishes();

            // Перевіряємо кількість страв у меню
            Assert.Equal(2, dishes.Count);
        }
    }
}