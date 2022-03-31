using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithms.Tests
{
  [TestClass]
  public class SortingAlgorithmTests
  {
    [TestMethod]
    public void SelectionSortTestCaseOne()
    {
      Random random = new Random();

      // make a list of size 0 to x and initialize with random positive integer values
      int size = random.Next(0, 20);
      List<int> unsortedList = new List<int>();
      for (int i = 0; i < size; i++)
      {
        unsortedList.Add(random.Next(0, 1000));
      }

      // making a cloned list and using native sorting algo as positive example
      List<int> positiveExample = new List<int>(unsortedList);
      positiveExample.Sort();

      // testing the algo
      try
      {
        List<int> sortedList = SortingAlgorithms.SelectionSort(unsortedList);
        Assert.IsTrue(sortedList.ToArray() == positiveExample.ToArray());
      } 
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    } // method
  } // class
} // namespace