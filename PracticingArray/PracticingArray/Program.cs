using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //int[] arr1 = new int[] { 1, 2, 3, 4 };

            //int[] arr2=new int[6] {6,6,7, 8,9,3 };  

            //int[] arr3 = new int[4];
            //arr3[0] = 1;

            //int[][] arr4 = { { 1, 2 }, { 2, 3 } }; //Wrong way

            //int[][] arr5 = new int[2][2] { { 1, 2 }, { 2, 3 } };  //Wrong way
            //int[][] arr6 = new int[][] { { 1, 2 }, { 2, 3 } };  //Wrong way

            //int[,] arr7 = new int[2][2] { { 1, 2 }, { 2, 3 } };    //wrong way

            int[,] arr8 = new int[3, 2] { { 2, 3 }, { 9, 4 }, { 5, 6 } };     // Correct way 

            int[,] arr81 = new int[,] { { 2, 3 }, { 9, 4 }, { 5, 6 } };     // Correct way 

            int[,] arr82 = { { 2, 3 }, { 9, 4 }, { 5, 6 } }; //correct way 




            int[,,] arr9 = new int[3, 2, 3]

            {

                { {1,2,3 }, { 4, 5,6 } },

                 { {1,2,3 }, { 4, 5,6 } },

                  { {1,2,3 }, { 4, 5,6 } }

            };

           

            //int[][] arr8 = new int[3][];
            //arr8[0]=new int[2];
            //arr8[1]=new int[3];
            //arr8[2]=new int[4];

            int[][] arr11 = new int[3][];
            arr11[0] = new int[] {1,2,3};
            arr11[1] = new int[] {2,7};
            arr11[2] = new int[] {1};

            int[][] arr2 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {2,7},
                new int[] {1},

            };

            int[][] arr3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            Console.WriteLine(arr9.Rank);





            //for (int i = 0; i < arr8.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr8.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr8[i][j]);

            //    }
            //}
            Console.ReadLine();
        }
    }
}
