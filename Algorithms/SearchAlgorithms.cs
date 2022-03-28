namespace Algorithms
{
  public class SearchAlgorithms
  {
    // returns the index of the item in a list
    // time complexity: log_2_n
    public static int BinarySearch(int[] sortedArray, int searchInt)
    {
      int returnIndex = -1;
      int lowIndex = 0;
      int highIndex = sortedArray.Length - 1;

      while (lowIndex <= highIndex)
      {
        int middleIndex = (int) Math.Floor((lowIndex + highIndex) / 2.0);
        int guess = sortedArray[middleIndex];

        if (guess == searchInt)
        {
          returnIndex = middleIndex;
          return returnIndex;
        }
        else if (guess > searchInt)
        {
          highIndex = middleIndex - 1;
        }
        else if (guess < searchInt)
        {
          lowIndex = middleIndex + 1;
        }
      }
      return returnIndex;
    }
  }
}
