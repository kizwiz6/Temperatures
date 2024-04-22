namespace Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array of temperatures
            double[] ts = { 7, -10, 13, 8, 4, -7.2, -12, -3.7, 3.5, -9.6, 6.5, -1.7, -6.2, 7 };

            // Call the ClosestToZero method with the array of temperatures.
            var result = Solution.ClosestToZero(ts);

            // Print the result.
            PrintResult(result);

            double[] ts2 = { 4, -1, 0.5, 5, 3, -7.2, -12, -3.7, 3.5, -9.6, 15.5, -7.7, -7.2, 42 };

            var result2 = Solution.ClosestToZero(ts2);

            PrintResult(result2);

        }

        /// <summary>
        /// Prints the result to the console.
        /// </summary>
        /// <param name="result">The result to print.</param>
        static void PrintResult(double result)
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
