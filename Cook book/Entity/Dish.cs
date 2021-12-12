using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Data
{
    internal class Dish
    {
        public List<string>? DishName { get; set; }
        public List<string>? Ingredients { get; set; }
        public List<string>? CookingStages { get; set; }
        public string? Description { get; set; }
    }
}
