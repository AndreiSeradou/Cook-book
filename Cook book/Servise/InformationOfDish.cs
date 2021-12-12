using Cook_book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Servise
{
    internal class InformationOfDish
    {
        private Dish _dish;
        InformationOfDish(Dish dish)
        {
            _dish = dish;
        }

        public void DisplayTheName()
        {
            Console.WriteLine(_dish.DishName);
        }

        public void DisplayTheInformation()
        {
            Console.WriteLine(_dish.Description);
        }
        public void DisplayTheIngredients()
        {
            Console.WriteLine(_dish.Ingredients);
        }
    }
}
