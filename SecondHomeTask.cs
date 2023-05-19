using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDZ
{
    internal class Program
    {
        /*
        Создайте приложение, которое производит операции
        над матрицами:

        1. Умножение матрицы на число;
        2. Сложение матриц;
        3. Произведение матриц.

        Матрица это двумерный массив.

        Создать в классе Program три метода, которые принимают на вход матрицу/ы и возвращают новую. 
        Сложение матриц выполняется поэлементно. Умножение матрицы на число, каждый элемент умножаем на число.
        Произведение матриц это пункт со звездочкой. 
        */
        static void Main(string[] args)
        {
            const int m = 4, n = 3, p = 2;
            int[,] matrix = new int[m, p] { { 1, 2 }, { 4, 5 }, { 7, 8 }, { 2, 4 } };

            int[,] matrix2 = new int[p, n] { { 1, 2, 5 }, { 4, 5, 9 } };

            Console.WriteLine("Исходная матрица:");
            ShowMatrix(ref matrix);
            //
            FirstProgram(ref matrix, 2);
            Console.WriteLine("Матрица после умножения на число:");
            ShowMatrix(ref matrix);
            //
            SecondProgram(ref matrix, matrix);
            Console.WriteLine("Сложение матриц:");
            ShowMatrix(ref matrix);
            //

            int[,] matrixAnsw = new int[m, n];
         
            Console.WriteLine("Исходная матрица 1:");
            ShowMatrix(ref matrix);
            Console.WriteLine("Исходная матрица 2:");
            ShowMatrix(ref matrix2);

            ThirdProgram(matrix, matrix2, m, n, p, ref matrixAnsw);
            Console.WriteLine("Умножение матриц:");
            ShowMatrix(ref matrixAnsw);
            
        }
        static void ShowMatrix(ref int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FirstProgram(ref int [,]matrix,in int value)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    matrix[i, j] *= value;
                }
                
            }
            
        }
        static void SecondProgram(ref int[,] matrix, int[,] matrix2)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    matrix[i, j] += matrix2[i, j];
                }

            }
        }

        static void ThirdProgram(in int[,] matrix, in int[,] matrix2 ,int m, int n, int p, ref int[,] newMatrix)
        {

           // int[,] newMatrix = new int[m, n]; 

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    newMatrix[i, j] = 0;
                    for (int k = 0; k < p; ++k)
                    {
                       
                        newMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                    //Console.WriteLine(newMatrix[i,j]);
                }

            }
            //ShowMatrix(ref newMatrix);
        }


    }
}
