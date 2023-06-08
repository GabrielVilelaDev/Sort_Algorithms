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
    public class InsertionSort : ISort
    {
        public List<int> Sort(List<int> numbersList)
        {
            int comparisons = 0, swaps = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < numbersList.Count(); i++)
            {
                int key = numbersList[i];
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

            StringBuilder logContent = new StringBuilder();
            logContent.Append("Tempo de execução: " + stopwatch.Elapsed.TotalMilliseconds + ",\n");
            logContent.Append("Número de comparações: " + comparisons + ",\n");
            logContent.Append("Número de trocas: " + swaps + ";\n");
            logContent.Append("\n\n\n\n");

            string fileName = $"InsertionSort_{DateTime.Now.ToString("yyyyMMdd_HH")}.txt";
            string filePath = Path.Combine(Paths.DirLogs, fileName);

            FileManager.Write(filePath, logContent.ToString());

            return numbersList;
        }
    }
}
