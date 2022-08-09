using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Algorithms
{
    //Complexity: O(N*N)
    internal class SelectionSort
    {

        public int[] Run(int[] arrayToSort)
        {
            if(arrayToSort == null || !arrayToSort.Any())
            {
                throw new ArgumentException("Array is null or empty");
            }
            var smallest = 0;
            for(int i = 0; i < arrayToSort.Length; i ++)
            {
                smallest = i;
                for(int j = i+1; j < arrayToSort.Length; j ++)
                {
                    if (arrayToSort[j] < arrayToSort[smallest])
                    {
                        smallest = j;
                    }
                }

                var temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[smallest];
                arrayToSort[smallest] = temp;

            }
            return arrayToSort;
        }
    }
}
