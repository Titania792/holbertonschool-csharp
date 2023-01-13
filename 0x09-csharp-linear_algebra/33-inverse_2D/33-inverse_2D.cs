﻿using System;

///<summary> 31. Inverse #2 </summary>
class MatrixMath
{
	///<summary> method that calculates the inverse of a 2D matrix and returns the resulting matrix. </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] adj = new double[2, 2];
        double[,] inv = new double[2, 2];
        double det = MatrixMath.Determinant(matrix);

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 || det == -1)
        {
            return new double[,] {{-1}};
        }

        adj[0, 0] = matrix[1, 1];
        adj[1, 1] = matrix[0, 0];
        adj[0, 1] = -matrix[0, 1];
        adj[1, 0] = -matrix[1, 0];

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                inv[i, j] = (adj[i, j])/(float)det;
            }
        }
        return inv;
    }
    
	///<summary> method that calculates the determinant of a matrix. </summary>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
			return Math.Round(((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])), 2);
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double a = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
			double b = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
			double c = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
			return Math.Round((a - b + c),2);
		}
		return - 1;
	}
}
