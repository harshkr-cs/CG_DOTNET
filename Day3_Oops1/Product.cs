using System;
class Product{
    public string Name;
    public int Price;

    public Product() { }

    public Product(string name, int price){
        Name = name;
        Price = price;
        Console.WriteLine("Product Name: " + Name);
        Console.WriteLine("Product Price: " + Price);
    }
}