using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithms.Tests
{
  [TestClass]
  public class BinarySearchTests
  {
    [TestMethod]
    public void BinarySearchTestCaseOne()
    {
      Random random = new Random();

      // make an array of size 0 to x and initialize with random positive integer values
      int size = random.Next(0, 20);
      int[] array = new int[size];
      for (int i = 0; i < size; i++)
      {
        array[i] = random.Next(0, 1000);
      }

      // preprocessing data for algo
      Array.Sort(array);
      
      // getting the expected index for testing
      int expectedIndex = random.Next(0, array.Length);
      int randomArrayValue = array[expectedIndex];
      int? returnedIndex = null;

      // testing the algo
      try
      {
        returnedIndex = SearchAlgorithms.BinarySearch(array, randomArrayValue);
      } 
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }

      Assert.IsTrue(expectedIndex == returnedIndex);
    }
  }
}