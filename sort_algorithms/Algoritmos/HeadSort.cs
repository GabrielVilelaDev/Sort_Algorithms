using System.Diagnostics;

namespace sort_algorithms.Algoritmos;

public class HeapSort : ISort
{
    static int comparisonCount;
    static int swapCount;
    public List<long> Sort(List<long> numbersList)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        HeapSortExecution(numbersList.ToArray());
        stopwatch.Stop();
        
        Services.Services.GenerateLogsAlgorithms(numbersList.Count(), comparisonCount, swapCount, stopwatch.Elapsed.TotalMilliseconds, this.GetType().Name);
        
        return numbersList;
    }
    
    public void HeapSortExecution(long[] array)
    {
        int n = array.Length;
        
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(array, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            Swap(array, 0, i);
            Heapify(array, i, 0);
        }
    }
    
    static void Heapify(long[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        comparisonCount += 3; 
     
        if (left < n && array[left] > array[largest])
            largest = left;
        
        if (right < n && array[right] > array[largest])
            largest = right;

        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, n, largest);
        }
    }
    
    static void Swap(long[] array, int i, int j)
    {
        swapCount++;

        long temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}