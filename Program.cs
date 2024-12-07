using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;
            int[,] mymatrix = new int[size, size];
            Random rnd = new Random();

            Console.WriteLine("Original matrix");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mymatrix[i, j] = rnd.Next(0, 101);
                    Console.Write(mymatrix[i, j].ToString().PadLeft(4)); //becasue with mymatrix[i, j] + " "; doesnt work well
                }
                Console.WriteLine();
            }


            int minAbsValue = int.MaxValue;
            int minRow = -1, minCol = -1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Math.Abs(mymatrix[i, j]) <= minAbsValue)
                    {
                        minAbsValue = Math.Abs(mymatrix[i, j]);
                        minRow = i;
                        minCol = j;
                    }
                }
            }
            Console.WriteLine($"\nThe absolute minimum value {mymatrix[minRow, minCol]} in the position ({minRow}, {minCol})");

            int newSize = size - 1;
            int[,] newMatrix = new int[newSize, newSize];
            int newRow = 0, newCol;

            for (int i = 0; i < size; i++)
            {
                if (i == minRow) continue;
                newCol = 0;

                for (int j = 0; j < size; j++)
                {
                    if (j == minCol) continue;
                    newMatrix[newRow, newCol] = mymatrix[i, j];
                    newCol++;
                }
                newRow++;
            }

            Console.WriteLine($"\n New transformed matrix");
            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    Console.Write(newMatrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
