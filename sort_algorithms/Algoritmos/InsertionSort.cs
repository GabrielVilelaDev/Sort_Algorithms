﻿using sort_algorithms.Consts;
using sort_algorithms.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithms.Algoritmos
{
    public class InsertionSort : ISort
    {
        public List<long> Sort(List<long> numbersList)
        {
            long comparisons = 0, swaps = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < numbersList.Count(); i++)
            {
                long key = numbersList[i];
                int j = i - 1;
                comparisons++;

                while (j >= 0 && numbersList[j] > key)
                {
                    numbersList[j + 1] = numbersList[j];
                    j = j - 1;
                    swaps++;
                }
                numbersList[j + 1] = key;
            }

            stopwatch.Stop();

            Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisons, swaps, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);

            return numbersList;
        }
    }
}
