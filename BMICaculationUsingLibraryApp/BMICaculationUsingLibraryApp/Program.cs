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

            float patientHeight = PatientDetailsLib.PatientDetailsType.SetHeightValue(userHeight);
            float patientWeight = PatientDetailsLib.PatientDetailsType.SetWeightValue(userWeight);

            float bmiValue = BMICalculatorLib.BMICalculatorType.CalculateBMI(patientWeight,patientHeight);

            string consoleMessage = BMIValueValidatorLib.BMIValueValidatorType.ValidateBMIValue(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);

        }
    }
}
