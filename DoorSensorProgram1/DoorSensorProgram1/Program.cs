using System;

namespace DoorSensorProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Security _securitySystem = new Security();
            DoorPositionHandler doorPositionChangeHandler = new DoorPositionHandler(_securitySystem.Receive);


            DoorSensor doorSensor = new DoorSensor();
            doorSensor.OnDoorPositionChanged += doorPositionChangeHandler;
            doorSensor.Open();
            doorSensor.Close();
        }
    }
}
