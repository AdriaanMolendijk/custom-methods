/// <summary>
/// This method determines whether two integers are permuations of each other.
/// </summary>
/// <param name="n1">the first number.</param>
/// <param name="n2">the second number.</param>
/// <returns>true iff n1 is a permutation of n2.</returns>
static bool ArePermutations(long n1, long n2)
{
    int[] digits1 = new int[10];
    int[] digits2 = new int[10];
    foreach (char c1 in n1.ToString())
        digits1[c1 - '0']++;
    foreach (char c2 in n2.ToString())
        digits2[c2 - '0']++;
    for (int digit = 0; digit <= 9; digit++)
    {
        if (digits1[digit] != digits2[digit]) return false;
    }
    return true;
}