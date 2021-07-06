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
            DisplayMessage display = new DisplayMessage();
            int height = display.SetHeight();
            int weight = display.SetWeight();

            CalculateBMI value = new CalculateBMI();
            value.SetHeight = height;
            value.SetWeight = weight;
            int result = value.CalculateResult();

            CheckBMICondition value2 = new CheckBMICondition();
            value2.BMIValidate(result);

            Console.ReadLine();
        }
    }
}
