using sort_algorithms.Algoritmos;
using sort_algorithms.Services;

long TotalInputSimulation = 30;
long inputLength = 2;

InsertionSort insSort = new InsertionSort();
Services.Sort(TotalInputSimulation, inputLength, insSort);

SelectionSort selecSort = new SelectionSort();
Services.Sort(TotalInputSimulation, inputLength, selecSort);

QuickSort quickSort = new QuickSort();
Services.Sort(TotalInputSimulation, inputLength, quickSort);

MergeSort mergeSort = new MergeSort();
Services.Sort(TotalInputSimulation, inputLength, mergeSort);

