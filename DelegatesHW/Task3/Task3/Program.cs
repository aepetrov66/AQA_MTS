namespace Task3;

class Program
{
    delegate double DoubleResult(double radius);
    static void Main()
    {
        int[] array = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(10);
        }

        Sort sort = new Sort();
        SortType sortType = SortType.Ascending;
        SortDelegate sortDelegate = sort.GetSortType(sortType);
        int[] sortedArray = sortDelegate(array);
        sort.Show(sortedArray);

        sortType = SortType.Descending;
        sortDelegate = sort.GetSortType(sortType);
        sortedArray = sortDelegate(array);
        sort.Show(sortedArray);
    }
}