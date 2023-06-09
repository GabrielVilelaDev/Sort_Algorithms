using sort_algorithms.Consts;
using sort_algorithms.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithms.Algoritmos
{
    public class SelectionSort : ISort
    {
        public List<long> Sort(List<long> numbersList)
        {
            long comparisons = 0, swaps = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbersList.Count; j++)
                {
                    comparisons++;
                    if (numbersList[j] < numbersList[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    long temp = numbersList[i];
                    numbersList[i] = numbersList[minIndex];
                    numbersList[minIndex] = temp;
                    swaps++;
                }
            }

            stopwatch.Stop();

            Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisons, swaps, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);

            return numbersList;
        }
    }
}
