using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculation
{
    public class CheckMyBmi
    {
        public int weight;
        public double height;
        public double bmi;
        public void ConsoleInput()
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("Weight in kg: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height in cm: ");
            height = Convert.ToDouble(Console.ReadLine());

        }


        public void CalculateBmi()
        {
             //calculation of BMI
             bmi = weight / height * 2;
        }
        public void Validate()
        {
            MessageDisplay obj = new MessageDisplay();
            if (bmi < 18.5)
            { obj.Underweight(); }
            if (bmi >= 19 & bmi <= 24)
            { obj.Healthy(); }
            if (bmi >= 25)
            { obj.Overweight(); }


        }

    }
}






   