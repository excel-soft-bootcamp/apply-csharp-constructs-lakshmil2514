using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class teacher : College
    {

        private string _teachername;
        public teacher (string ID,string name):base (ID)
        {
            this._teachername = name;
            public void subject()
            {

            }
        }

    }
}
