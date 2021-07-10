using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensorProgram
{
    public delegate void DoorStatusHandler(string status);
    class DoorSensor
    { 
      
        string status;

        public event DoorStatusHandler OnDoorStatusChanged;
        public void Open()
        {
            status = "Opened";
            this.Notify();


        }
        public void Close()
        {
            status = "Closed";
            this.Notify();

        }
        void Notify()
        {
           
            OnDoorStatusChanged.Invoke(this.status);
        }


    }
}
