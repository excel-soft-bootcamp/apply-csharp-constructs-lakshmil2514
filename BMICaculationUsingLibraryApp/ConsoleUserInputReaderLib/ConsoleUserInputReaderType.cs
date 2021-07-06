using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUserInputReaderLib
{
    public static class ConsoleUserInputReaderType
    {
        public static float ReadHeightOfUser()
        {
            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter height in meters");
            float heightValue = float.Parse(Console.ReadLine());
            return heightValue;
        }
        public static float ReadWeightOfUser()
        {
            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter weight in kilos");
            float weightValue = float.Parse(Console.ReadLine());
            return weightValue;
        }
    }
}
