using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Algorithms
{
    //Complexity: O(log N), where N - number of elements in given array
    internal class BinarySearch<T> where T:IComparable
    {
        public int? Run(IList<T> array, T itemToFind)
        {
            if(array == null || !array.Any() || itemToFind == null)
            {
                throw new ArgumentException("Some of corresponding arguments is null");
            }
            var low = 0;
            var high = array.Count - 1;
            while (low <= high)
            {
                var mid = (high + low) / 2;
                var guess = array[mid];

                if (guess!.Equals(itemToFind))
                {
                    return mid;
                }

                if(itemToFind.CompareTo(guess) > 0)
                {
                    low = mid + 1;
                } 
                else
                {
                    high = mid - 1;
                }
            }

            return null;

        }
    }
}
