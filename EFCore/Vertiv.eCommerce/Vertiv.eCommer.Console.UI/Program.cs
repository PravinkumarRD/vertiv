// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Vertiv.eCommerce.DbFirst;

Console.WriteLine("List all ShoeWorld Categories");
var myShoeWorldContext=new MyShoeWorldDbContext();
//myShoeWorldContext.Categories.ToList().ForEach(category => Console.WriteLine(category.CategoryName));
var CategoriesAndProducts = from category in myShoeWorldContext.Categories
                            join
                            product in myShoeWorldContext.Products
                            on category.CategoryId equals product.CategoryId
                            where category.CategoryName== "Sports Shoes"
                            orderby product.ProductName descending
                            select new { CategoryName=category.CategoryName, ProductName=product.ProductName, DiscountedPrice=product.UnitPrice -(product.UnitPrice*product.Discount/100) };
//foreach (var item in CategoriesAndProducts)
//{
//    Console.WriteLine($"Under Category {item.CategoryName}, we have product {item.ProductName} with discounted price INR - {item.DiscountedPrice}/-");
//}
/*myShoeWorldContext.Categories.Add(new() { CategoryName = "Sneakers", Description = "All Sneakers for men and women!" });*/

//myShoeWorldContext.Categories.Remove(myShoeWorldContext.Categories.Find(4));
//int result = myShoeWorldContext.SaveChanges();

myShoeWorldContext.CategoryWiseProducts.ToList().ForEach(category => Console.WriteLine($"{category.ProductName} belongs to Catgeory {category.CategoryName}"));

var categories = myShoeWorldContext.Categories.FromSqlRaw("select * from Categories");

categories.ToList().ForEach(category => Console.WriteLine(category.CategoryName));

Console.ReadKey();
