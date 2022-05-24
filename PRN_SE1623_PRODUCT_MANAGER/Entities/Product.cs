namespace Prn.Se1623;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Desc { get; set; }
    public int CategoryID { get; set; }
    public double UnitPrice { get; set; }


    public Product()
    {

    }

    public Product(int id, string productName, string desc, int categoryID, double unitPrice)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        CategoryID = categoryID;
        UnitPrice = unitPrice;
    }

    public override string? ToString() => $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, Category ID = {CategoryID}, Unit Price = {UnitPrice}]";

 
}