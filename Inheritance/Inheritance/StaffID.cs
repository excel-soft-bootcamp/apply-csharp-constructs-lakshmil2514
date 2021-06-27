using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StaffID : IdCardDetails
    {
        private string _designation;
       
        public StaffID(string ID,string designation,string address) : base(ID,address)
        {
            this._designation =designation;
           
        }
    }
}
