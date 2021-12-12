using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_book.Servise
{
    internal class Timer
    {
        public int timer = default;

        public int start()
        {
            if (timer < 0)
            {
                return timer * -1;
            }

            timer++;

            return start();
        }

        public void stop()
        {
            timer *= -1;
        }
    }
}
