using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StudentID : Collegemember
    {
        private string _stuname;
        public StuudentID(string name,string Id):base(Id)
        {
            this._stuname = name;

           
        }
    }
}
