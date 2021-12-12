using Cook_book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Servise
{
    internal class SearchDishByName
    {
        private Dish _dish;
        SearchDishByName(Dish dish)
        {
            _dish = dish;
        }

        public void DisplayAllIngredients()
        {
            Console.WriteLine(_dish.DishName);
        }

        public List<string> GetIngredients(string name)
        {
            return (List<string>)_dish.DishName.Where(n => n.Equals(name));
        }
    }
}
