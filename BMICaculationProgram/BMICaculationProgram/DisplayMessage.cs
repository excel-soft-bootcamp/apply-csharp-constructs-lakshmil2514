using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICaculationProgram
{
    class DisplayMessage
    {
        private int height, weight;
        public int SetHeight
        {
            set
            {
                this.height = value;
            }
        }
        public int SetWeight
        {
            set
            {
                this.weight = value;
            }
        }
        public int GetHeight(int height)
        {
            return height;
        }
        public int GetWeight(int weight)
        {
            return weight;
        }


        public void Underweight()
        {
            Console.WriteLine("Underweight:");

        }
        public void Overweight()
        {
            Console.WriteLine("Overweight:");

        }
        public void Normal()
        {
            Console.WriteLine("Normal:");

        }
    }
}
