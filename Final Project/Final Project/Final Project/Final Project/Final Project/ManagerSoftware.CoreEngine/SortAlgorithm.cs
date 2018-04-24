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
            Archive repos = null;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (array[j].Id > array[j + 1].Id)
                    {
                        repos = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = repos;
                    }
                }
            }
        }
    }
}