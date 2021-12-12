using Cook_book.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book
{
    internal class Program
    {
        private Cookbook? cookbook;
        public void Start()
        {
            cookbook = new Cookbook();
        }

        public void Stop()
        {
            cookbook = null;
        }
    }
}
