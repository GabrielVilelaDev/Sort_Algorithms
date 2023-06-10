using sort_algorithms.Algoritmos;
using sort_algorithms.Consts;
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
        public static List<long> GenerateRandomListNumbers(long totalElements)
        {
            Random rand = new Random();
            List<long> returnElements = new List<long>();
            for (int i = 0; i < totalElements; i++)
            {
                returnElements.Add(rand.Next());
            }
            return returnElements;
        }
        public static List<long> Sort(long TotalInputSimulation, List<long> inputLength, ISort sortAlgorithm)
        {
            List<long> sorted = new List<long>();
            for (int i = 0; i < inputLength.Count; i++)
            {
                for (int j = 0; j < TotalInputSimulation; j++)
                {
                    sorted = sortAlgorithm.Sort(GenerateRandomListNumbers(inputLength[i])); 
                }
            }
            return sorted;
        }
        public static void GenerateLogsAlgorithms(int inputLenght, long comparisons, long swaps, double miliseconds, string sortAlgorithmName)
        {
            StringBuilder logContent = new StringBuilder();
            logContent.Append(inputLenght.ToString() + ';');
            logContent.Append(miliseconds.ToString() + ';');
            logContent.Append(comparisons.ToString() + ';');
            logContent.Append(swaps.ToString());
            logContent.Append('\n');

            Console.WriteLine(logContent);

            string fileName = $"{sortAlgorithmName}_{DateTime.Now.ToString("yyyyMMdd_HH")}.csv";
            string filePath = Path.Combine(Paths.DirLogs, fileName);

            FileManager.Write(filePath, logContent.ToString());
        }
    }
}
