using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SecuritySystem _security_Observer = new SecuritySystem();
            DoorStatusHandler doorStatusHandler = new DoorStatusHandler(_security_Observer.Notify);


            DoorSensor _doorSensor = new DoorSensor();
            _doorSensor.OnDoorStatusChanged += doorStatusHandler;
            _doorSensor.Open();
            _doorSensor.Close();

        }
    }
}
