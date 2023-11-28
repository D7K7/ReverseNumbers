using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] reversedNumbers = new int[n];
    
    for (int i=0; i < n; i++)
    {
      reversedNumbers[i] = n-i;
    }
    
    return reversedNumbers;
  }
}
