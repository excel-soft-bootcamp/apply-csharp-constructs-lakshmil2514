using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace BMICaculationProgram

{
    public class ChooseOption
    {

        public void ChoosedOption()
        {

            Console.WriteLine("Enter the choice");
            Console.WriteLine("1:Input 2:.CSV file");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                float userHeight = ConsoleUserInputReaderLib.ConsoleUserInputReaderType.ReadHeightOfUser();
                float userWeight = ConsoleUserInputReaderLib.ConsoleUserInputReaderType.ReadWeightOfUser();

                float patientHeight = PatientDetailsLib.PatientDetailsType.SetHeightValue(userHeight);
                float patientWeight = PatientDetailsLib.PatientDetailsType.SetWeightValue(userWeight);

                float bmiValue = BMICalculatorLib.BMICalculatorType.CalculateBMI(patientWeight, patientHeight);

                string consoleMessage = BMIValueValidatorLib.BMIValueValidatorType.ValidateBMIValue(bmiValue);

                ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);
            }
            else if (choice == 2)
            {
                 var streamReader = File.OpenText($"C:\Users\lakshmi.l\Documents\CSV Files");
                var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
                csvReader.Configuration.HasHeaderRecord = true;

                string value;

                while (csvReader.Read())
                {
                    for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
                    {
                        Console.Write($"{value} ");
                    }

                    Console.WriteLine();
                }

            }



        }
    }
}
