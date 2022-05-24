using Prn.Se1623;

ProductManager productManager = new ProductManager();
productManager.Add(new Product(1,"Macbook Pro 2022","Day la macbook manh nhat 2022",1,2500d));

productManager.Add(new Product(2, "Macbook Pro 2023", "Day la macbook manh nhat 2023", 1, 500d));
productManager.Add(new Product(3, "Macbook Pro 2024", "Day la macbook manh nhat 2023", 1, 4500d));

productManager.Display();

Console.WriteLine("======================");
Console.WriteLine(productManager.Get(1));

Console.ReadLine();

