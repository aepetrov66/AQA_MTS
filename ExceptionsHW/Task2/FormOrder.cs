namespace Task2;

internal class FormOrder
{
    public static bool MakeOrder(int orderId, List<string> products, string delivery)
    {

        if (orderId <= 0)
        {
            throw new InvalidOrderNumberException("Некорректный номер заказа.");
        }
        else if (products == null)
        {
            throw new EmptyOrderException("Список товаров пуст.");
        }
        else if (delivery == null)
        {
            throw new DeliveryInformationMissingException("Адрес доставки не заполнен.");
        }
        else
        {
            return true;
        }
    }
}
