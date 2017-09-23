using Attache;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Attache.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void IsNotDivisibleBy3()
        {
            int[] values = new int[] {
                // Not multiples of 3
                8,
                17,
                88,
                // Multiples of 5, but not 3
                5,
                50,
                // A negative number
                -11
            };

            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy3(v);
                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void IsDivisibleBy3()
        {
            int[] values = new int[] {
                // Treat zero as a multipe of 3
                0,
                // Multiples of 3
                3,
                9,
                99,
                // Multiple of 3 and 5
                15,
                // A negative number
                -21
            };

            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy3(v);
                Assert.IsTrue(result);
            }
        }

        [TestMethod()]
        public void IsNotDivisibleBy5()
        {
            int[] values = new int[] {
                // Not multiples of 5
                8,
                88,
                // Multiples of 3, but not 5
                18,
                72,
                // A negative number
                -31
            };
            
            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy5(v);
                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void IsDivisibleBy5()
        {
            int[] values = new int[] {
                // Treat zero as a multipe of 5
                0,
                // Multiples of 5
                5,
                80,
                // Multiple of 3 and 5
                75,
                // A negative
                -65
            };

            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy5(v);
                Assert.IsTrue(result);
            }
        }

        [TestMethod()]
        public void IsNotDivisibleBy3And5()
        {
            int[] values = new int[] {
                // Not multiples of 3, nor 5
                1,
                11,
                71,
                // Multiples of 3, not 5
                3,
                18,
                83,
                // Multiples of 5, not 3
                5,
                55,
                10
            };

            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy3And5(v);
                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void IsDivisibleBy3And5()
        {
            int[] values = new int[] {
                // Treat zero as a multipe of 3 and 5
                0,
                // Test multiples of 3 and 5
                15,
                90,
                // Test a negative multiple
                -15
            };

            foreach (var v in values)
            {
                bool result = FizzBuzz.DivisibleBy3And5(v);
                Assert.IsTrue(result);
            }
        }

        [TestMethod()]
        public void IsNotFizz()
        {
            int[] values = new int[]
            {
                // Not multipe of 3
                1,
                19,
                61,
                98
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreEqual(LevelOfFizzBuzz.NONE, result);
            }

            values = new int[]
            {
                // Multiples of 5, but not 3
                10,
                35,
                95
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                // These values are not multiples of 3
                Assert.AreEqual(LevelOfFizzBuzz.NONE, result & LevelOfFizzBuzz.FIZZ);
            }
        }

        [TestMethod()]
        public void IsFizz()
        {
            int[] values = new int[]
            {
                // Multiples of 3
                3,
                9,
                99,
                // A negative
                -72
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreEqual(LevelOfFizzBuzz.FIZZ, result);
            }

            values = new int[]
            {
                // Treat zero as a multipe of 3 and 5
                0,
                // Multiples of 3 and 15
                15,
                45,
                90,
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreNotEqual(LevelOfFizzBuzz.FIZZ, result);
                // These values are still multiples of 3
                Assert.AreEqual(LevelOfFizzBuzz.FIZZ, result & LevelOfFizzBuzz.FIZZ);
            }
        }

        [TestMethod()]
        public void IsNotBuzz()
        {
            int[] values = new int[]
            {
                // Not multipe of 5
                1,
                19,
                61,
                98
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreEqual(LevelOfFizzBuzz.NONE, result);
            }

            values = new int[]
            {
                // Multiples of 3, but not 5
                9,
                48,
                81
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                // These values are not multiples of 3
                Assert.AreEqual(LevelOfFizzBuzz.NONE, result & LevelOfFizzBuzz.BUZZ);
            }
        }

        [TestMethod()]
        public void IsBuzz()
        {
            int[] values = new int[]
            {
                // Multiples of 5
                10,
                40,
                85,
                // A negative
                -50
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreEqual(LevelOfFizzBuzz.BUZZ, result);
            }

            values = new int[]
            {
                // Treat zero as a multipe of of 3 and 15
                0,
                // Multiples of 3 and 15
                15,
                45,
                90,
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreNotEqual(LevelOfFizzBuzz.BUZZ, result);
                // These values are still multiples of 5
                Assert.AreEqual(LevelOfFizzBuzz.BUZZ, result & LevelOfFizzBuzz.BUZZ);
            }
        }

        [TestMethod()]
        public void IsNotFizzBuzz()
        {
            int[] values = new int[]
            {
                // Multipes of neither 3, nor 5
                7,
                11,
                67,
                97,
                // Multipes of 3, not 5
                3,
                6,
                27,
                78,
                // Multipes of 5, not 3
                10,
                25,
                95
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreNotEqual(LevelOfFizzBuzz.FIZZ_BUZZ, result);
            }
        }

        [TestMethod()]
        public void IsFizzBuzz()
        {
            int[] values = new int[]
            {
                // Treat zero as a multipe of 3 and 5
                0,
                // Multiples of 5
                15,
                45,
                90,
                // A negative
                -45
            };

            foreach (var v in values)
            {
                LevelOfFizzBuzz result = FizzBuzz.GetFizzBuzz(v);
                Assert.AreEqual(LevelOfFizzBuzz.FIZZ_BUZZ, result);
            }
        }
    }
}
