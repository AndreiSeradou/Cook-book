using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Data
{
    internal class CreatedDishes
    {
        public List<Dish>? CreatedAllDishes { get; set; }

        public List<Dish>? GetCreatedDishes() 
        { 
            return CreatedAllDishes;
        }

        public void ChooseDish()
        {
            throw new NotImplementedException();
        }
    }
}
