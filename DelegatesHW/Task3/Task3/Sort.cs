namespace Task3;
public delegate int[] SortDelegate(int[] array);
public class Sort
{
    public int[] DescendingSort(int[] array)
    {
        var orderedNumbers = from i in array orderby i descending select i;
        return orderedNumbers.ToArray();
    }

    public int[] AscendingSort(int[] array)
    {
        var orderedNumbers = from i in array orderby i ascending select i;
        return orderedNumbers.ToArray();
    }

    public SortDelegate GetSortType(SortType sortType)
    {
        switch (sortType)
        {
            case SortType.Ascending:
                return AscendingSort;
            case SortType.Descending:
                return DescendingSort;
            default:
                throw new Exception();
        }
    }
    public void Show(int[] array)
    {
        Console.Write("{ ");
        foreach (var i in array)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("}");
    }
}
