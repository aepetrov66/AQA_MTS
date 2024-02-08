namespace Task2;

public class GenericArray<T>
{
    public static T[] array = { };

    public static void Add(T item)
    {
        T[] newArray = new T[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = item;
        array = newArray;
    }

    public static void Remove(int index)
    {
        T[] newArray = new T[array.Length - 1];
        Array.Copy(array, newArray, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        array = newArray;
    }

    public static T GetByIndex(int index)
    {
        return array[index];
    }



    public static void ShowArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}, тип: {array[i].GetType().ToString()}");
        }
    }
}

