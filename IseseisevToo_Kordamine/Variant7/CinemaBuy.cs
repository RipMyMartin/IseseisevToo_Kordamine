using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_Kordamine.Variant7
{
    internal class CinemaBuy
    {
        /*Покупка билетов в кино. На экран выводится схема зала, заполненая 0 и 1 (случайным образом).
        Пользователь указывает ряд и место, если оно свободно,
        то в массив вместо нуля записывается 1 и на экран опять отображается зал.*/

        public static void GenerateCinemaHall(int[,] hall)
        {
            Random random = new Random();
            int rows = hall.GetLength(0);
            int cols = hall.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    hall[i, j] = random.Next(0, 2);
                }
            }
        }
    }
}
