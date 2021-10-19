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
                var pivot = listToBeOrdered[start];
                var startintPoint = start + 1;
                var endingPoint = end;

                while (startintPoint <= endingPoint)
                {
                    if (listToBeOrdered[startintPoint] <= pivot)
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

        public List<int> mergeSort(int firstValue, int secondValue)
        {
            var numberList = new List<int>();

            if (firstValue >= secondValue)
            {
                numberList.Add(firstValue);
                numberList.Add(secondValue);
            }
            else
            {
                numberList.Add(secondValue);
                numberList.Add(firstValue);
            }

            return numberList;
        }

        public void printArray(List<int> arrayToPrint)
        {
            arrayToPrint.ForEach(Console.WriteLine);
        }
    }
}