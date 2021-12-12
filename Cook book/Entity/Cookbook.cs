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
        public ClassOfDish? classOfDish;
        public CreatedDishes? createdDishes = new CreatedDishes();
        public  CreateDish? createDish;
        public SearchByIngredients? searchByIngredients;
        public SearchDishByName? searchDishByName;
        public Favourites favourites = new Favourites();
        public void RunTheSelectionByClass()
        {
            classOfDish = new ClassOfDish();
            Console.WriteLine(classOfDish);
        }

        public void StartCreatingDish()
        {
            createDish = new CreateDish();
            Console.WriteLine(createDish);
        }

        public void SearchForDishByName()
        {
            searchDishByName = new SearchDishByName();
            Console.WriteLine(searchDishByName);
        }

        public void SearchForDishByIngredients()
        {
            searchByIngredients = new SearchByIngredients();
            Console.WriteLine(searchByIngredients);
        }
    }
}
