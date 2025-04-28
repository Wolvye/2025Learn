using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part2
{
    internal class Plane : Vehicle, IVihicle
    {
        public bool HasJetDrive { get; set; }

        public void Move()
        {
            Console.WriteLine("Die Räder befinden sich in der Luft");
        }

        public virtual void Landing()
        {
            Console.WriteLine("Landeanflug mit Passagieren");
        }
    }
}
