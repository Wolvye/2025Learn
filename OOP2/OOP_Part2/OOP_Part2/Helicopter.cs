using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part2
{
    class Helicopter : Plane
    {
        public override void Landing()
        {
            
           // base.Landing();

            Console.WriteLine("Der Helicopter sinkt langsam");
        }

    }
}
