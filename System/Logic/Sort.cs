using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Logic
{
    public class Sort
    {
        private static void swap(UserData[] arr, int i, int j)
        {
            UserData temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static UserData[] convertToArr(List<UserData> data)
        {
            UserData[] Data = data.ToArray();

            return Data;
        }

        // O(n^2) Sorting Algorithm
        public static UserData[] regularSort(UserData[] array)
        {

            for (int j = 0; j <= array.Length -2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (int.Parse(array[i].AverageGrade) > int.Parse(array[i + 1].AverageGrade))
                    {
                        swap(array, i + 1, i);
                    }
                }
            }

            return array;
        }








        public static UserData[] quickSort(UserData[] array, int leftIndex, int rightIndex)
        {
            if(leftIndex <=0 && rightIndex < 0) { return array = new UserData[0]; }
            var i = leftIndex;
            var j = rightIndex;
            var pivot = int.Parse(array[leftIndex].AverageGrade);

            while (i <= j)
            {
                while (int.Parse(array[i].AverageGrade) < pivot)
                {
                    i++;
                }

                while (int.Parse(array[j].AverageGrade) > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    swap(array, i, j);
                    i++;
                    j--;
                }

            }

            if (leftIndex < j)
                quickSort(array, leftIndex, j);
            if (i < rightIndex)
                quickSort(array, i, rightIndex);

            return array;
        }
    }
}
