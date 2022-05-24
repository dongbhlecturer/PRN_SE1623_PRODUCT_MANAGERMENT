namespace Prn.Se1623;
public interface IProduct
{
    void Add(Product p);
    void Remove(Product p);
    Product Get(int pos);
    void Display();

}