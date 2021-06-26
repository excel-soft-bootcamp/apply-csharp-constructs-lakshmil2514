using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StaffID :Collegememeber
    {
        private string _staffName;
        public StaffID(string ID,string name) : base(ID)
        {
            this._staffName = name;
           
        }
    }
}
