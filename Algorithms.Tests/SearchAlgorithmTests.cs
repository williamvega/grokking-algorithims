using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithms.Tests
{
  [TestClass]
  public class SearchAlgorithmTests
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
    } // method 

    [TestMethod]
    public void FindSmallest()
    {
      Random random = new Random();

      // make a list of size 0 to x and initialize with random positive integer values
      int size = random.Next(0, 20);
      List<int> unsortedList = new List<int>();
      for (int i = 0; i < size; i++)
      {
        unsortedList.Add(random.Next(0, 1000));
      }

      // find the index of the smallest integer in the list
      List<int> positiveExample = new List<int>(unsortedList);
      positiveExample.Sort();
      int expectedIndex = unsortedList.IndexOf(positiveExample[0]);
      int? returnedIndex = null;

      // testing the algo
      try
      {
        returnedIndex = SearchAlgorithms.FindSmallest(unsortedList);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }

      Assert.IsTrue(expectedIndex == returnedIndex);
    } // method
  } // class
} // namespace