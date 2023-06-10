using System.Diagnostics;

namespace sort_algorithms.Algoritmos;

public class ShellSort : ISort
{
    static int comparisonCount;
    static int swapCount;
    public List<long> Sort(List<long> numbersList)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        Shellsort(numbersList.ToArray());
        
        stopwatch.Stop();
        
        Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisonCount, swapCount, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);
        
        return numbersList;
    }
    
    static void Shellsort(long[] array)
    {
        int n = array.Length;
        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                long temp = array[i];
                int j = i;

                comparisonCount++; 

                while (j >= gap && array[j - gap] > temp)
                {
                    array[j] = array[j - gap];
                    j -= gap;
                    swapCount++; 
                }

                array[j] = temp;
            }

            gap /= 2;
        }
    }
}