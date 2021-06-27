using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class GuestID : IdCardDetails
    {
        private string _Guestname;
        public GuestID(string ID,string name,string address): base(ID,address)
        {
            this._Guestname=name;
           
        }
    }
}
