using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            float userHeight= ConsoleUserInputReaderLib.ConsoleUserInputReaderType.ReadHeightOfUser();
            float userWeight = ConsoleUserInputReaderLib.ConsoleUserInputReaderType.ReadWeightOfUser();

            float userHeightvalue = PatientDetailsLib.PatientDetailsType.SetHeightValue(userHeight);
            float userWeightValue = PatientDetailsLib.PatientDetailsType.SetWeightValue(userWeight);

            float bmiValue = BMICalculatorLib.BMICalculatorType.CalculateBMI(userWeightValue,userHeightvalue );

            string consoleMessage = BMIValueValidatorLib.BMIValueValidatorType.ValidateBMIValue(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);

        }
    }
}
