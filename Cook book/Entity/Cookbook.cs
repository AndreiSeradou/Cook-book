using Cook_book.Data;
using Cook_book.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Entity
{
    internal class Cookbook
    {
        public ClassOfDish classOfDish = new ClassOfDish();
        public CreatedDishes createdDishes = new CreatedDishes();
        public  CreateDish createDish = new CreateDish();
        public SearchByIngredients searchByIngredients = new SearchByIngredients();
        public SearchDishByName searchDishByName = new SearchDishByName();
        public Favourites favourites = new Favourites();
        public void RunTheSelectionByClass()
        {
            
        }

        public void StartCreatingDish()
        {

        }

        public void SearchForDishByName()
        {

        }

        public void SearchForDishByIngredients()
        {

        }
    }
}
