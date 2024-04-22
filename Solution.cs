using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatures
{
    /// <summary>
    /// Provides a method to find the temperature closest to zero in an array of temperatures.
    /// </summary>
    internal class Solution
    {
        /// <summary>
        /// Finds the temperature closest to zero in the given array of tempereatures.
        /// </summary>
        /// <param name="ts">The array of temperatures.</param>
        /// <returns>The temperature closest to zero.</returns>
        public static double ClosestToZero(double[] ts)
        {
            // If the array is empty, return 0
            if (ts.Length == 0) return 0;

            // Initialize closest temperature to the first element
            double closestTemperature = ts[0];

            // Iterate through the array to find the closest temperature to zero
            foreach (double temperature in ts)
            {
                // Check if the current temperature is closer to zero than the previously found closest temperature
                if (Math.Abs(temperature) < Math.Abs(closestTemperature) ||
                   (Math.Abs(temperature) == Math.Abs(closestTemperature) && temperature > 0))
                {
                    closestTemperature = temperature;
                }
            }

            return closestTemperature;
        }
    }
}
