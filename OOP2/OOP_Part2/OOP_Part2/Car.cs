﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part2
{
    internal class Car : Vehicle, IVhicle
    {
        public void Move()
        {
            Console.WriteLine("Vier Räder haben Bodenkontakt");
        }
    }
}
