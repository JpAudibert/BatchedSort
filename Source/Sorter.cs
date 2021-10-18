using System;
using System.Collections.Generic;

namespace Source
{
    class Sorter
    {
        public List<int> quickSort(List<int> listToBeOrdered)
        {
            var start = 0;
            var end = listToBeOrdered.Count - 1;

            quickSort(listToBeOrdered, start, end);

            return listToBeOrdered;
        }

        private void quickSort(List<int> listToBeOrdered, int start, int end)
        {
            if (start < end)
            {
                int pivot = listToBeOrdered[start];
                int startintPoint = start + 1;
                int endingPoint = end;

                while (startintPoint <= endingPoint)
                {
                    if(listToBeOrdered[startintPoint] <= pivot)
                    {
                        startintPoint++;
                    }
                    else if (pivot < listToBeOrdered[endingPoint])
                    {
                        endingPoint--;
                    }
                    else
                    {
                        int aux = listToBeOrdered[startintPoint];
                        listToBeOrdered[startintPoint] = listToBeOrdered[endingPoint];
                        listToBeOrdered[endingPoint] = aux;
                        startintPoint++;
                        endingPoint--;
                    }
                }

                listToBeOrdered[start] = listToBeOrdered[endingPoint];
                listToBeOrdered[endingPoint] = pivot;

                quickSort(listToBeOrdered, start, endingPoint - 1);
                quickSort(listToBeOrdered, endingPoint + 1, end);
            }
        }

        public void printArray(List<int> arr)
        {
            arr.ForEach(Console.WriteLine);
        }
    }
}