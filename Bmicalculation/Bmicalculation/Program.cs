using System;

namespace Bmicalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine();

            Console.Write("Weight in kg: ");
            int kg;
            kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in cm: ");
            double m;
            m = Convert.ToDouble(Console.ReadLine());

            //calculation of BMI
            double BMI;
            BMI = kg / m * 2;

            if (BMI < 18.5 )
            { Console.WriteLine("-> Underweight"); }
            if (BMI >=19 & BMI <= 24)
            { Console.WriteLine("-> Healthy"); }
            if (BMI >=25)
            { Console.WriteLine("-> Overweight"); }

           

          
        }
    }
}
