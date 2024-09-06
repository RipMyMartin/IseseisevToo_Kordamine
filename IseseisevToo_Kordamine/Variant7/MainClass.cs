using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_Kordamine.Variant7
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 8, 9, 10 }
            };
            MultiMassFunc.ReverseArr(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sisendsõna: ");
            string wrd = Console.ReadLine();
            Console.WriteLine("Śisestage number: ");
            string str = Console.ReadLine();
            Console.WriteLine("Osalemine {0}", BoolTextFunc.IsAttend(str, wrd));
        }
    }
}
