using sort_algorithms.Algoritmos;
using sort_algorithms.Services;

int TotalInputSimulation = 30;
int inputLength = 30;
var rand = new Random();

for (int i = 0; i < TotalInputSimulation; i++)
{
    InsertionSort insSort = new InsertionSort();
    List<int> testSorted = insSort.Sort(Services.GenerateRandomListNumbers(2 ^ inputLength));
}