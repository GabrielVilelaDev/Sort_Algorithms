using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithms.Services
{
    public static class Services
    {
        public static List<int> GenerateRandomListNumbers(int totalElements, int minValue, int maxValue)
        {
            Random rand = new Random();
            List<int> returnElements = new List<int>();
            for (int i = 0; i < totalElements; i++)
            {
                returnElements.Add(rand.Next(minValue, maxValue));
            }
            return returnElements;
        }
        public static List<int> GenerateRandomListNumbers(int totalElements)
        {
            Random rand = new Random();
            List<int> returnElements = new List<int>();
            for (int i = 0; i < totalElements; i++)
            {
                returnElements.Add(rand.Next());
            }
            return returnElements;
        }
    }
}
