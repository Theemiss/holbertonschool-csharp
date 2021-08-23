using System;
/// <summary>
/// class MatrixMath
/// </summary>

    class MatrixMath
    {
    /// <summary>
    /// Add 2 Matrice to each other
    /// </summary>
    /// <param name="matrix1">Matrice 1</param>
    /// <param name="matrix2"> Matrice 2</param>
    /// <returns>return the sum of 2</returns>
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.Length != matrix2.Length ||
                matrix1.GetLength(0) != matrix1.GetLength(1) ||
                matrix2.GetLength(0) != matrix2.GetLength(1)){
                    return (new Double[,]{{-1}});}
        
             double[,] res = new double[matrix1.GetLength(0),matrix1.GetLength(1)];

             for (int i = 0; i < matrix1.GetLength(0); i++){
                for (int j = 0; j < matrix1.GetLength(1); j++){
                    res[i, j] = matrix1[i,j] + matrix2[i,j];
            }
        }
             return res;
    }}