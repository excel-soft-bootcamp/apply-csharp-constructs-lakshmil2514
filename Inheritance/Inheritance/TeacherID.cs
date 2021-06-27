using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TeacherID : IDCardDetails
    {

        private string _dept;

        public TeacherID (string ID,string dept,string address):base (ID,address)
        {
            this._dept = dept;
            
        }

    }
}
