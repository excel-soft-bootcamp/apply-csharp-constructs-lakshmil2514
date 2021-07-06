using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetailsLib
{
    public static class PatientDetailsType
    {
        private static float heightInMeters;
        private static float weightInKilos;

        public static float SetHeightValue(float _heightValue)
        {
            heightInMeters = _heightValue;
            return heightInMeters;
        }

        public static float SetWeightValue(float _weightValue)
        {
            weightInKilos = _weightValue;
            return weightInKilos;
        }
    }
}
