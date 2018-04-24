using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    internal class SortAlgorithm
    {
        //Bubble Sort
        public static void Bubblesort(Archive[] array, int length)
        {
            Archive[] repos = new Archive[1];
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (arr[j].IdentificationNumber > arr[j + 1].IdentificationNumber)
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                    }
                }
            }
        }
    }
}