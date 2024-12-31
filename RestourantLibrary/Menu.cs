using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Клас для управління меню ресторану
    public class Menu
    {
        private List<Dish> dishes; // Список для зберігання всіх страв у меню

        public Menu()
        {
            dishes = new List<Dish>(); // Ініціалізуємо список
        }

        // Додає страву до меню
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        // Видаляє страву з меню за назвою
        public void RemoveDish(string name)
        {
            dishes.RemoveAll(d => d.Name == name);
        }

        // Повертає список усіх страв у меню
        public List<Dish> GetDishes()
        {
            return dishes;
        }
    }
}
    
