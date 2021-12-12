using Cook_book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Servise
{
    internal class CreateDish
    {
        public int CookingQueue { get; set; }
        public bool save { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllIngredients()
        {
            return new List<string>();
        }

        public void SetUpAQueue()
        {
            CookingQueue = new int();
        }
    }
}
