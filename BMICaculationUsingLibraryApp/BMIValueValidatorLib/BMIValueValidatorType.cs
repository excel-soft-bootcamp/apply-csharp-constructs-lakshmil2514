using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIValueValidatorLib
{
    public static class BMIValueValidatorType
    {
        public static string ValidateBMIValue(float BMIValue)
        {
            if (BMIValue < 18.5)
            {
                return "UNDERWEIGHT";
            }
            else if (BMIValue >= 25)
            {
                return "OVERWEIGHT";
            }
            else
            {
                return "HEALTHY";
            }
        }
    }
}
