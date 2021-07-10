using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensorProgram
{
    class SecuritySystem
    {
        public void Notify(string status)
        {
            string message = $"Door {status} and Time:{System.DateTime.Now.ToString()}";
            Console.WriteLine(message);
        }
    }
    
}
