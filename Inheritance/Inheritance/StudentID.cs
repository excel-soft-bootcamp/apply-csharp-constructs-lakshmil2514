using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StudentID : IDCardDetails
    {
        private string _stuname;
        public StudentID(string name,string Id,string address):base(Id,address)
        {
            this._stuname = name;

           
        }
    }
}
