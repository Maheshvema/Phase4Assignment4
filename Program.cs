// See https://aka.ms/new-console-template for more information
using ConAppProducts;
SortedList<string, Products> products = new SortedList<string, Products>();
products.Add("Milk", new Products { PName = "Milk", PPrice = 40,PBrand="Amul",ManufacturingDate=new DateTime(2024,1,10),ExpiryDate=new DateTime(2024,1,10) });
products.Add("GHEE", new Products { PName = "GHEE", PPrice = 100, PBrand = "Amul", ManufacturingDate = new DateTime(2024, 1, 10), ExpiryDate = new DateTime(2024, 1, 10) });
products.Add("PANEER", new Products { PName ="PANEER", PPrice = 80, PBrand = "Amul", ManufacturingDate = new DateTime(2024, 1, 10), ExpiryDate = new DateTime(2024, 1, 10) });
Console.WriteLine("Pname \t PPrice \t PBrand \t ManufacturingDate \t ExpiryDate");
foreach (KeyValuePair<string, Products> productPair in products)
{
    Console.Write(productPair.Value.PName+"\t");
    Console.Write(productPair.Value.PPrice+"\t");
    Console.Write(productPair.Value.PBrand+"\t\t");
    Console.Write(productPair.Value.ManufacturingDate+"\t\t");
    Console.Write(productPair.Value.ExpiryDate+"\t\t");
    Console.Write("\n");
}