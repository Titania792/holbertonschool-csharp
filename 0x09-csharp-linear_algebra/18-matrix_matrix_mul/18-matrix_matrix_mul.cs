using System;

/// <summary> 18. Matrix-matrix multiplication #1 </summary>
class MatrixMath
{
    /// <summary> method that multiplies two matrices and returns the resulting matrix. </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || 
            matrix1.GetLength(0) != matrix2.GetLength(0) ||
            (matrix1.GetLength(1) != 2 && matrix1.GetLength(1) != 3) ||
            matrix1.GetLength(0) != matrix1.GetLength(1))
            return new double[,] {{-1}};
        
        double[,] nmatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int t = 0; t < matrix1.GetLength(1); t++)
                {
                    nmatrix[i, j] += matrix1[i, t] * matrix2[t, j];
                }
            }
        }
        return nmatrix;
    }
}
