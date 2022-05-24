namespace Prn.Se1623;
public class ProductManager : AbstractProduct, IProduct
{
    public ProductManager() { }
    public void Add(Product p)
    {
        //1. extend size of Products
        if (Size >= Products.Length)
        {
            Product[] tmp = new Product[Size*2];
            for (int i = 0; i < Size; i++)
            {
                tmp[i] = Products[i];
            }
            Products = tmp; //tham chieu toi mang moi
        }

        Products[Size++] = p;
        
    }

    public void Display()
    {
     for(int i = 0; i < this.Size; i++)
        {
            Console.WriteLine(Products[i]);
        }   
    }

    public Product Get(int pos)
    {
        if(pos < 0||pos >= Size)
        {
            return null;
        }
        return this.Products[pos];
    }

    public void Remove(Product p)
    {
        throw new NotImplementedException();
    }
}