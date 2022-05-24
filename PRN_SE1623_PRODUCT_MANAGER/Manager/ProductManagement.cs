namespace Prn.Se1623;
public class ProductManager : AbstractProduct, IProduct
{
    public ProductManager() { }
    public void Add(Product p)
    {
       this.Products.Add(p);
    }

    public void Display()
    {
        foreach (var item in this.Products)
        {
            Console.WriteLine(item);
        } 
    }

    public Product Get(int pos)
    {
        return this.Products[pos];
    }

    public void Remove(Product p)
    {
        throw new NotImplementedException();
    }
}