using OO_Samples_027_NumberConverter_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Tests
{
    public class NumberConverterDummy
    {
        public NumberConverterDummy() { }

        public int RoundUp(float value)
        {
            return 42;
        }

        public int RoundDown(float value)
        {
            return 42;
        }


        public int RoundToPowerOfTen(float value, int precisionExponent = 1)
        {
            return 42;
        }

        public int RoundToPowerOfTen(string numericString, int precisionExponent = 1)
        {
            return 42;
        }
    }
}
