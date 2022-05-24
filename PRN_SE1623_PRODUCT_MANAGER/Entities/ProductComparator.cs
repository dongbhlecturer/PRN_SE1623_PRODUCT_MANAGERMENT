namespace Prn.Se1623;
public class ProductComparatorByUnitPrice : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        return x.UnitPrice.CompareTo(y.UnitPrice);
    }
}