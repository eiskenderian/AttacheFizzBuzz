using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attache
{
    public enum LevelOfFizzBuzz
    {
        NONE = 0x00,
        FIZZ = 0x01,
        BUZZ = 0x10,
        FIZZ_BUZZ = FIZZ | BUZZ
    }

    public class FizzBuzz
    {
        public static bool DivisibleBy3(int value)
        {
            return 0 == value % 3;
        }

        public static bool DivisibleBy5(int value)
        {
            return 0 == value % 5;
        }

        public static bool DivisibleBy3And5(int value)
        {
            return DivisibleBy3(value) && DivisibleBy5(value);
        }

        public static LevelOfFizzBuzz GetFizzBuzz(int value)
        {
            LevelOfFizzBuzz result = LevelOfFizzBuzz.NONE;

            if (DivisibleBy3And5(value))
                result = LevelOfFizzBuzz.FIZZ_BUZZ;
            else if (DivisibleBy3(value))
                result = LevelOfFizzBuzz.FIZZ;
            else if (DivisibleBy5(value))
                result = LevelOfFizzBuzz.BUZZ;

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
