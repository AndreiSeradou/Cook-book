using Cook_book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Servise
{
    internal class SearchByIngredients
    {
        private Dish _dish;
        SearchByIngredients(Dish dish)
        {
            _dish = dish;
        }

        public void DisplayAllIngredients()
        {
            Console.WriteLine(_dish.Ingredients);
        }

        public List<string> GetIngredients(string name)
        {
            return (List<string>)_dish.Ingredients.Where(n=> n.Equals(name));
        }
    }
}
