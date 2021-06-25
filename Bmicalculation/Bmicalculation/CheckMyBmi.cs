using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculation
{
    public class CheckMyBmi
    {
            public int weight;//kilogram
            public double height;//meters
            public double bmi;//body mass index 

            public int Weight_Kg
            {
                set { this.weight = value; }
                get { return this.weight; }
            }

            public double Height_M
            {
                set { this.height = value; }
                get { return this.height; }
            }


            public void CalculateBmi()
            {


            //calculation of BMI
            double bmi;
            bmi = Weight_Kg / Height_M* 2;

            if (bmi< 18.5)
            { Console.WriteLine(" Underweight"); }
            if (bmi >= 19 & bmi <= 24)
            { Console.WriteLine("Healthy"); }
            if (bmi >= 25)
            { Console.WriteLine("Overweight"); }


        }
            
            


public void ConsoleBmi()
{ 


       
        Console.WriteLine("BMI Calculator");
        Console.WriteLine("Weight in kg: ");
        Weight_Kg = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height in cm: ");
        Height_M = Convert.ToDouble(Console.ReadLine());
        


}
}
}






   