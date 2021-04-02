/// <summary>
/// This method determines whether a string is palindrome or not.
/// </summary>
/// <param name="s">the string s.</param>
/// <returns>true iff s is palindrome.</returns>
static bool IsPalindrome(string s)
{
  int l = s.Length;
  if (l <= 1) return true;

  // l >= 2 here
  char c1 = s[0];
  char c2 = s[l - 1];
  return (c1 == c2) && IsPalindrome(s.Substring(1, l - 2));
}