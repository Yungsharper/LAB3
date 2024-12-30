using Xunit;
using Lab3;

namespace MenuAndOrderLibrary.Tests
{
    public class DishTests
    {
        [Fact]
        public void Dish_CanBeCreated_WithValidProperties()
        {
            // Arrange
            string name = "Pizza";
            decimal price = 12.99m;

            // Act
            var dish = new Dish(name, price);

            // Assert
            Assert.Equal("Pizza", dish.Name);
            Assert.Equal(12.99m, dish.Price);
        }
    }
}
