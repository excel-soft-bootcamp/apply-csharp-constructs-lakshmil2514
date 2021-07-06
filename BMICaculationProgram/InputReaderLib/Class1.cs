using System;

namespace InputReaderLib
{
    public class Class1
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
        public int CalculateResult(int result)
        {

            return result = weight / height;

        }
    }
}
