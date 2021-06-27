using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StaffID : IdCardDetails
    {
        private string _staffName;
       
        public StaffID(string ID,string name,string address) : base(ID,address)
        {
            this._staffName = name;
           
        }
    }
}
