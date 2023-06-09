using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithms.Algoritmos
{
    public class MergeSort : ISort
    {
        int comparisons;
        int swaps;

        public List<long> Sort(List<long> numbersList)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<long> returnList = MergeSortExecution(numbersList);

            stopwatch.Stop();

            Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisons, swaps, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);
            return returnList;
        }

        public List<long> MergeSortExecution(List<long> numbersList)
        {
            List<long> left = new List<long>();
            List<long> right = new List<long>();

            if (numbersList.Count <= 1)
            {
                return numbersList;
            }

            int middle = numbersList.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(numbersList[i]);
            }

            for (int i = middle; i < numbersList.Count; i++)
            {
                right.Add(numbersList[i]);
            }

            left = MergeSortExecution(left);
            right = MergeSortExecution(right);
            return Merge(left, right);
        }

        private List<long> Merge(List<long> left, List<long> right)
        {
            var result = new List<long>();

            while (left.Count > 0 && right.Count > 0)
            {
                comparisons++;
                if (left.First() <= right.First())
                {
                    swaps++;
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    swaps++;
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            while (left.Count > 0)
            {
                swaps++;
                result.Add(left.First());
                left.Remove(left.First());
            }

            while (right.Count > 0)
            {
                swaps++;
                result.Add(right.First());
                right.Remove(right.First());
            }

            return result;
        }
    }
}
