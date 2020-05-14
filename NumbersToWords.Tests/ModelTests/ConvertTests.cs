using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ConvertNumberTests
  {
    [TestMethod]
    public void Constructor_StoresDigitsInQueue_IntQueue()
    {
      string userInput = "123";
      ConvertNumber newNum = new ConvertNumber(userInput);
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Queue<int> result = newNum.GetQueue();

      CollectionAssert.AreEqual(result, queue);
    }

    [TestMethod]
    public void GetNextDigit_DequeuesDigit_Digit()
    {
      string userInput = "123";
      ConvertNumber newNum = new ConvertNumber(userInput);

      int result = newNum.GetNextDigit();

      Assert.AreEqual(result, 1);
    }
  }
}