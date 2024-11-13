namespace Variant15.Tests
{
    public class UnitTest
    {
        [Fact]
        public void TestCalc_ValidNumberWithPrimeDivisors()
        {
            // Test for a number (30) that has multiple prime divisors (2, 3, 5).
            var values = new List<int> { 30 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(3, result[0]);
            Console.WriteLine($"Result for input 30 (should have 3 prime divisors): {result[0]}");
        }

        [Fact]
        public void TestCalc_ValidNumberWithNoPrimeDivisors()
        {
            // Test for a number (1) which has no prime divisors.
            var values = new List<int> { 1 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(0, result[0]);
            Console.WriteLine($"Result for input 1 (should have 0 prime divisors): {result[0]}");
        }

        [Fact]
        public void TestCalc_PrimeNumber()
        {
            // Test for a prime number (7) which should have only itself as a divisor.
            var values = new List<int> { 7 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(1, result[0]);
            Console.WriteLine($"Result for input 7 (should have 1 prime divisor): {result[0]}");
        }

        [Fact]
        public void TestCalc_LargeCompositeNumber()
        {
            // Test for a larger composite number (1000) with prime divisors (2, 5).
            var values = new List<int> { 1000 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(2, result[0]);
            Console.WriteLine($"Result for input 1000 (should have 2 unique prime divisors): {result[0]}");
        }

        [Fact]
        public void TestCalc_MultipleNumbers()
        {
            // Test for multiple numbers (10, 15, 21) with their respective prime divisors.
            var values = new List<int> { 10, 15, 21 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Equal(3, result.Count);
            Assert.Equal(2, result[0]); // Prime divisors of 10: 2, 5
            Assert.Equal(2, result[1]); // Prime divisors of 15: 3, 5
            Assert.Equal(2, result[2]); // Prime divisors of 21: 3, 7
            Console.WriteLine($"Results for inputs 10, 15, 21 (should be 2, 2, 2): {string.Join(", ", result)}");
        }

        [Fact]
        public void TestCalc_NegativeNumber()
        {
            // Test for a negative number (-30), which should be treated like its absolute value.
            var values = new List<int> { -30 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(3, result[0]); // Prime divisors of 30: 2, 3, 5
            Console.WriteLine($"Result for input -30 (should have 3 prime divisors): {result[0]}");
        }

        [Fact]
        public void TestCalc_LargePrimeNumber()
        {
            // Test for a large prime number (997) which should only have one prime divisor (itself).
            var values = new List<int> { 997 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Single(result);
            Assert.Equal(1, result[0]);
            Console.WriteLine($"Result for input 997 (should have 1 prime divisor): {result[0]}");
        }

        [Fact]
        public void TestCalc_EmptyList()
        {
            // Test for an empty input list.
            var values = new List<int>();
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Empty(result);
            Console.WriteLine($"Result for an empty list (should be empty): {result.Count}");
        }

        [Fact]
        public void TestCalc_MultipleNumbersWithRepeats()
        {
            // Test for repeated numbers (6, 6, 6) and ensure consistent results.
            var values = new List<int> { 6, 6, 6 };
            var result = Program.CalculatePrimeDivisorCounts(values);
            Assert.Equal(3, result.Count);
            Assert.All(result, count => Assert.Equal(2, count)); // Prime divisors of 6: 2, 3
            Console.WriteLine($"Results for repeated input 6 (each should have 2 prime divisors): {string.Join(", ", result)}");
        }
    }
}
