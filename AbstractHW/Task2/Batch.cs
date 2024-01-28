namespace Task2;

public class Batch : AbstractProduct
{
    public List<Product> products {  get; set; }

    public Batch()
    {
        this.products = new List<Product>();    
    }

    public override void GetDescription()
    {
        foreach (Product product in products)
        {
            product.GetDescription();
        }
    }

    public override bool IsProductAllive()
    {
        bool flag = true;
        foreach(Product product in products)
        {
            if (!product.IsProductAllive())
            {
                flag = false;
            }
        }

        return flag;
    }
}
