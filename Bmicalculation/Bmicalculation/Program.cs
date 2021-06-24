using System;

namespace Bmicalculation
{
    class checkMyBmi

    {
        private int kg;//kilogram
        private double m;//meters
        private double bmi;//body mass index 

        public int Weight_Kg
        {
            set { this.kg = value; }
            get { return this.kg; }
        }

        public double Height_M
        {
            set { this.m = value; }
            get { return this.m; }
        }


        public double  CalculateBmi
        {
       

            //calculation of BMI
            double bmi;
            bmi = Weight_Kg / Height_M * 2;

            if (bmi < 18.5)
            { Console.WriteLine(" Underweight"); }
            if (bmi >= 19 & bmi <= 24)
            { Console.WriteLine("Healthy"); }
            if (bmi >= 25)
            { Console.WriteLine("Overweight"); }


        }
 }
            




        class StartPoint
        {
             static void Main(string[] args)
                {
                    checkMyBmi person = new checkMyBmi();
                     Console.WriteLine("BMI Calculator");
                     Console.WriteLine("Weight in kg: ");
                     Weight_kg = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Height in cm: ");
                     Height_M = Convert.ToDouble(Console.ReadLine());
                          person.CalculateBmi();

                 }
        }
}
