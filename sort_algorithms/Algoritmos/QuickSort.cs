using System.Diagnostics;
using System.Text;
using sort_algorithms.Consts;
using sort_algorithms.Services;

namespace sort_algorithms.Algoritmos;

public class QuickSort : ISort
{
    int comparisonCount;
    int swapCount;
    
    public List<long> Sort(List<long> numbersList)
    {
        int low = 0;
        int high = numbersList.Count - 1;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        Quicksort(numbersList.ToArray(), low, high);
        
        stopwatch.Stop();

        Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisonCount, swapCount, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);

        return numbersList;
    }

    private void Quicksort(long[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            Quicksort(array, low, pivotIndex - 1);

            Quicksort(array, pivotIndex + 1, high);
        }
    }
    private int Partition(long[] array, int low, int high)
    {
        long pivot = array[high];
        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            comparisonCount++;

            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);

        return i + 1;
    }

    private void Swap(long[] array, int i, int j)
    {
        swapCount++;

        long temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}