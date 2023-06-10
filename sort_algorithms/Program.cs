using sort_algorithms.Algoritmos;
using sort_algorithms.Services;

long TotalInputSimulation = 30;
List<long> inputLength = new List<long>(){100,1000,10000,100000};

InsertionSort insSort = new InsertionSort();
Services.Sort(TotalInputSimulation, inputLength, insSort);

SelectionSort selecSort = new SelectionSort();
Services.Sort(TotalInputSimulation, inputLength, selecSort);

QuickSort quickSort = new QuickSort();
Services.Sort(TotalInputSimulation, inputLength, quickSort);

MergeSort mergeSort = new MergeSort();
Services.Sort(TotalInputSimulation, inputLength, mergeSort);

HeapSort heapSort = new HeapSort();
Services.Sort(TotalInputSimulation, inputLength, heapSort);

ShellSort shellSort = new ShellSort();
Services.Sort(TotalInputSimulation, inputLength, shellSort);