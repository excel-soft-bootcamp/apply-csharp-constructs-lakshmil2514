using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TeacherID : IDCardDetails
    {

        private string _teachername;

        public TeacherID (string ID,string name,string address):base (ID,address)
        {
            this._teachername = name;
            
        }

    }
}
