using Prn.Se1623;

ProductManager productManager = new ProductManager();
productManager.Add(new Product(1,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,2500d));

productManager.Add(new Product(2, "Macbook Pro 2023", "Day la macbook manh nhat 2023", 1, 500d));
productManager.Add(new Product(3, "Macbook Pro 2024", "Day la macbook manh nhat 2023", 1, 4500d));

//productManager.Display();
/*

SortedSet<Product> list = new SortedSet<Product>();
list.Add(new Product(1, "Macbook Pro 2021", "Day la macbook manh nhat 2022", 1, 2500d));
list.Add(new Product(2, "Macbook Pro 2022", "Day la macbook manh nhat 2022", 1, 500d)); 
list.Add(new Product(3, "Macbook Pro 2023", "Day la macbook manh nhat 2022", 1, 23300d)); 
list.Add(new Product(4, "Macbook Pro 2024", "Day la macbook manh nhat 2022", 1, 2520d));


Product[] arrData = list.ToArray<Product>(); 
Array.Sort(arrData);
*/


Product[] arrProduct = new Product[] {
new Product(1,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,2300d),
new Product(2,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,2400d),
new Product(3,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,300d),
new Product(4,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,89900d)
};

//Array.Sort(arrProduct,new ProductComparatorByUnitPrice());
Array.Sort(arrProduct, (a, b) => (int)(- a.UnitPrice + b.UnitPrice));

foreach (Product product in arrProduct)
{
    Console.WriteLine(product);
}
Console.ReadLine();





