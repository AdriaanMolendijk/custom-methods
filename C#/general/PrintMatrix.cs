/// <summary>
/// This method prints out a matrix.
/// </summary>
/// <param name="A">an int[,] representing the matrix A.</param>
static void PrintMatrix(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}