using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part2
{
    abstract class Vehicle
    {
        public float Speed { get; set; }
        public float Accerlation { get; set; }
        public float BreakSpeed {  get; set; }
        public int DoorCount { get; set; }
    }
}
