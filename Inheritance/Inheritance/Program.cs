using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentID student1 = new StudentID("ram", "4MA", "Mysore");
            TeacherID teacher1 = new TeacherID("swathi", "4MA", "Banglore");
            GuestID guest1 = new GuestID("krishna", "4MA", "Manglore");
            StaffID staff1 = new StaffID("sham", "4MA", "Chennai");
        }



    }
}
