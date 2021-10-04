using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    class Program
    {
        static int score = 0;
        static int lives = 3; // Lives LEFT
        static bool alive = true; // true if alive, false if dead
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 2");
            lives = lives - 1;
            if (lives == 0)
           {
                lives = 0;
                alive = false;
           }
            Console.ReadKey(true);
        }
    }
}
