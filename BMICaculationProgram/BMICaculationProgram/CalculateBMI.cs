using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    public class CalculateBMI
    { 
         private int height, weight, result;

         public int SetHeight
         {
             set
             {
                 this.height = value;
             }
         }
         public int SetWeight
         {
            set
            {
                this.weight = value;
            }
         }
        public int CalculateResult(int result)
        {

            InputReaderLib.Class1.CalculateResult();

        }

    }
}
