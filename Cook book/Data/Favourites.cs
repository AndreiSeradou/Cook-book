using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Data
{
    internal class Favourites
    {
        public List<Dish>? ListFavourites { get; set; }

        public List<Dish>? GetFavouritesDishes()
        {
            return ListFavourites;
        }

        public void ChooseDish()
        {
            throw new NotImplementedException();
        }
    }
}
