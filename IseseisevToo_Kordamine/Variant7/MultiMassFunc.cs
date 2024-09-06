using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_Kordamine.Variant7
{
    internal static class MultiMassFunc
    {
        /* В двухмерном массиве переставьте попарно соседние строки,
         *т.е. 1-ю со 2-ой, 3-ю с 4-й и т.д. Результат выведите на экран.*/

        //int[,] arr2d = new int[3,2]{  {1, 2}, {3, 4}, {5, 6} };
        public static void ReverseArr(int[,] arr)
        {
            for (int i = 1; i < arr.GetLength(0); i += 2)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i - 1, j];
                    arr[i - 1, j] = temp;
                }
            }
        }
    }
}
