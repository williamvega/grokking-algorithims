namespace Algorithms
{
  public class SortingAlgorithms
  {
    // sorts a least in ascending order
    // time complexity: n^2
    public static List<int> SelectionSort(List<int> list)
    {
      List<int> returnList = new List<int>();
      for (int i = 0; i < list.Count; i++)
      {
        int smallestIndex = SearchAlgorithms.FindSmallest(list);
        returnList.Append(list[smallestIndex]);
        list.RemoveAt(smallestIndex);
      }
      return returnList;
    }
  }
}