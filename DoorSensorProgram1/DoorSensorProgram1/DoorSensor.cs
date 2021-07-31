using System;
using System.Collections.Generic;
using System.Text;

namespace DoorSensorProgram1
{
    public delegate void DoorPositionHandler(string position);
    public class DoorSensor
    {
        string status;
        public event DoorPositionHandler OnDoorPositionChanged;
        public void Open()
        {
            status = "open";
            this.Send();

        }

        public void Close()
        {
            status = "close";
            this.Send();
        }
        public void Send()
        {
            string message = $"{this.status} and Time : {System.DateTime.Now.ToString()}";
            OnDoorPositionChanged.Invoke(message);
        }



    }
}
