using Task2;

namespace Task1;

public class Program
{

    public static void Main()
    {
        int id = -10;
        List<string> list = new List<string>();
        string delivery = null;
        bool result = false;

        try
        {
            result = FormOrder.MakeOrder(id, list, delivery);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(result);
        }

        id = 10;
        try
        {
            result = FormOrder.MakeOrder(id, list, delivery);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(result);
        }

        list.Add("Яблоки");
        list.Add("Газета");
        try
        {
            result = FormOrder.MakeOrder(id, list, delivery);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(result);
        }
        
        delivery = "Ул. Пушкина, д. Колотушкина";
        try
        {
            result = FormOrder.MakeOrder(id, list, delivery);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(result);
        }

    }
}