using Encapsulation;
namespace Encapsulation;

public class Program : Product
{
    public Program(string brandName, string model, int price, int cost, int count)
        : base(brandName, model, price, cost, count)
    {
    }

    static void Main(string[] args)
    {

        Product product = new Product("apple", "iphone", 999, 600, 17);


        Console.WriteLine(string.Concat("ID: ", product.IdMaker(product.BrandName, product.Model)));


        product.GetInfo();


        (var updatedCount, var updatedIncome) = product.Sale(product.Income, product.Price, product.Cost, product.Count, 3);


        product.Count = updatedCount;
        product.Income = updatedIncome;


        Console.WriteLine($"Updated Income: {updatedIncome}, Updated Count: {updatedCount}");
        Phone phone = new Phone("apple", "iphone", 999, 500, 13, 8, "red", 1.2m);
        Console.WriteLine(phone.Call(6, phone.Balance));

        Console.ReadLine();
    }
}
