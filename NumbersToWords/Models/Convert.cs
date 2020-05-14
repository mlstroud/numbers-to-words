using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class ConvertNumber
  {
    private Queue<int> _digits;
    private List<string> _ones;
    private List<string> _tens;
    private List<string> _teens;

    public ConvertNumber(string inputNumber)
    {
      char[] letters = inputNumber.ToCharArray();
      _digits = new Queue<int>();

      foreach (char letter in letters)
      {
        _digits.Enqueue((int)(char.GetNumericValue(letter)));
      }
    }

    public Queue<int> GetQueue()
    {
      return _digits;
    }
  }
}