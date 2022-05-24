namespace Prn.Se1623;
public abstract class AbstractProduct
{
    private Product[]? _products;
    
    protected int Size { get; set; }//so luong phan tu co thuc trong mang
    protected Product[]? Products { get => _products; set => _products = value; }

    protected AbstractProduct()
    {
        this._products = new Product[Utils.InitLength];
        Size = 0;
    }


}