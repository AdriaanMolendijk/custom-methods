/// <summary>
/// This method prints out the solution to a given sudoku.
/// </summary>
/// <param name="sudoku">an int[,] representing the sudoku.</param>
static void SolveSudoku(int[,] sudoku)
{
    int[] indices = GetNextEntry(sudoku);
    
    // sudoku is solved
    if (indices[0] == -1)
    {
        PrintMatrix(sudoku);
        return;
    }

    int indexRow = indices[0], indexCol = indices[1];
    HashSet<int> numbers = GetGuesses(sudoku, indexRow, indexCol);
    foreach (int num in numbers)
    {
        int[,] newSudoku = sudoku.Clone() as int[,];
        newSudoku[indexRow, indexCol] = num;
        SolveSudoku(newSudoku);
    }
}

/// <summary>
/// This method returns the set of guesses for a sudoku entry at (row,col).
/// </summary>
/// <param name="sudoku">an int[,] representing the sudoku.</param>
/// <param name="row">the row index.</param>
/// <param name="col">the col index.</param>
/// <returns>a Hashset<int> containing the guesses.</returns>
static HashSet<int> GetGuesses(int[,] sudoku, int row, int col)
{
    HashSet<int> numbers = new HashSet<int>();
    for (int i = 1; i <= 9; i++) numbers.Add(i);

    // remove row and column numbers
    for (int i = 0; i < 9; i++)
    {
        int num = sudoku[row, i];
        if (num != 0) numbers.Remove(num);
        num = sudoku[i, col];
        if (num != 0) numbers.Remove(num);
    }
    
    // remove numbers in the same subgrid
    for (int r = 0; r < 3; r++)
    {
        for (int c = 0; c < 3; c++)
        {
            int num = sudoku[(row / 3) * 3 + r, (col / 3) * 3 + c];
            if (num != 0) numbers.Remove(num);
        }
    }

    return numbers;
}

/// <summary>
/// This method returns the pair of indices of a zero entry in a sudoku.
/// </summary>
/// <param name="sudoku">an int[,] representing the sudoku</param>
/// <returns>an int[] arrary arr, where arr[0] and arr[1] are the row and column of the zero entry.</returns>
static int[] GetNextEntry(int[,] sudoku)
{
    int[] indices = {-1, -1};
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (sudoku[i, j] == 0)
            {
                indices[0] = i;
                indices[1] = j;
                return indices;
            }
        }
    }
    return indices;
}

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