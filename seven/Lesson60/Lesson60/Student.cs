using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson60
{
    internal class Student
    {

        public string name { get; }
        public string lastName { get; }
        public string adress { get; }
        public int roomNumber { get; }
        public float nC { get; }





        public Student(string Name, string LastName, string Adress, int RoomNumber, float NC)
        {
            name = Name;
            lastName = LastName;
            adress = Adress;
            roomNumber = RoomNumber;
            nC = NC;

        }
    }
}
