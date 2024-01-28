using Task2;

public class Program
{

    public static void Main()
    {
        Batch batch = new Batch();

        Set set1 = new Set("Помидоры", 160, new DateTime(2024, 01, 20), 10, 10);
        batch.products.Add(set1);

        Set set2 = new Set("Огурцы", 190, new DateTime(2024, 01, 10), 10, 10);
        batch.products.Add(set2);

        Set set3 = new Set("Яблоки", 150, new DateTime(2024, 01, 10), 20, 10);
        batch.products.Add(set3);

        Set set4 = new Set("Груши", 150, new DateTime(2024, 01, 25), 5, 10);
        batch.products.Add(set4);

        batch.GetDescription();
    }
}