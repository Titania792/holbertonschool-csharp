using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                myMatrix[i,j] = (int)Math.Pow(myMatrix[i,j], 2);
        }
        return myMatrix;
    }
}

