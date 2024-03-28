// See https://aka.ms/new-console-template for more information
using Efcore.CodeFirst;

Console.WriteLine("Hello, World!");

var dbContext = new CodeFirstDbContext();
foreach (var item in dbContext.Products)
{
    Console.WriteLine($"{item.Key} - {item.Name} - {item.Price} - {(item.IsAvailable ? "Available" : "Unailable")}");
}