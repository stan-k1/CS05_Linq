using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;

namespace CS05_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> productList = 
            //     new() {"Smartphone", "Laptop", "Mouse", "Keyboard"};
            //
            // IEnumerable<string> procuctsFromL =
            //     productList
            //         .Where(product => product.StartsWith('L'))
            //         .Select(product => product.ToUpper());
            //
            // IEnumerable<string> procuctsFromLCopy = 
            //     from product in productList
            //     where product.StartsWith('L')
            //     select product.ToUpper();
            //
            // foreach (string product in procuctsFromL)
            // {
            //     Console.WriteLine(product);
            // }

            // IEnumerable<string> products = Product.Products
            //     .Select(p => p.ToString().ToLower());

            //IEnumerable<string> productsQ = from p in Product.Products
            //    select p.ToString().ToLower();

            //foreach (var p in products)
            //{
            //    Console.WriteLine(p);
            //}

            //List<string> productsDescList = products.ToList();
            //string[] productsDescArray = products.ToArray();

            //Dictionary<int, string> ProductsDic = Product.Products
            //    .ToDictionary(p => p.Id, p => p.Name);

            //Dictionary<int, string> ProductsDicQ =
            //    (from p in Product.Products select p)
            //    .ToDictionary(p => p.Id, p => p.Name);

            //List<string> productsD = Product.Products
            //    .Select(p => p.ToString().ToLower())
            //    .ToList();

            //List<string> productsDQ = 
            //    (from p in Product.Products
            //    select p.ToString().ToLower())
            //    .ToList();

            //List<char> chars = new() {'a', 'b', 'c'};
            //IEnumerable<char> CharsQuery = chars;
            //chars.Remove('b');
            //foreach (char ch in CharsQuery)
            //{
            //    Console.WriteLine(ch); //a c
            //}
            //
            // List<Product> Product_NamePrice =
            //     (Product.Products.Select(p => 
            //         new Product() { Id = p.Id, Name = p.Name})
            //     ).ToList();
            //
            // List<Product> Product_NamePriceQ =
            //     (from p in Product.Products
            //         select new Product() { Id = p.Id, Name = p.Name }
            //     ).ToList();
            //
            // var Anonymous_NamePrice =
            //     (Product.Products.Select(p =>
            //         new { p.Id, p.Name })
            //     ).ToList();
            //
            // var Anonymous_NamePriceQ =
            //     (from p in Product.Products
            //         select new { p.Id, p.Name }
            //     ).ToList();
            //
            // var manufacturers = new[]
            // {
            //     new
            //     {
            //         CompanyName = "ThreeStars",
            //         ProductSeries = new[] {"Universe", "Nebula"}
            //     },
            //     new
            //     {
            //         CompanyName = "Watermelon",
            //         ProductSeries = new[] {"uPhone", "uPad"}
            //     }
            // };
            //
            // var productSerieses = manufacturers
            //     .SelectMany(m => m.ProductSeries)
            //     .ToList();
            //
            // var productSeriesesQ = (from m in manufacturers
            //     from s in m.ProductSeries
            //     select s).ToList();
            //
            // foreach (var s in productSerieses)
            // {
            //     Console.WriteLine(s); //Universe Nebula uPhone uPad
            // }

            // var orderedProducts = Product.Products
            //     //.Select(p => p)
            //     .OrderBy(p => p.Price)
            //     .ToList();
            //
            // var orderedProductsQ = 
            //     (from p in Product.Products
            //     orderby p.Price
            //     select p)
            //     .ToList();
            //
            // var orderedProductsDesc = Product.Products
            //     .Select(p => p)
            //     .OrderByDescending(p => p.Price)
            //     .ThenByDescending(p => p.Color)
            //     .ThenBy(p => p.Id)
            //     .ToList();
            //
            // var orderedProductsDescQ =
            //     (from p in Product.Products
            //         orderby p.Price descending, p.Color descending, p.Id
            //         select p)
            //     .ToList();

            // var filteredProducts = Product.Products
            //     //.Select(p => p)
            //     .Where(p=>p.Color.StartsWith('B') || p.Price>=1000)
            //     .ToList();
            //
            // var orderedProductsQ =
            //     (from p in Product.Products
            //         where p.Color.StartsWith('B') || p.Price >= 1000
            //      select p)
            //     .ToList();

            // var first = Product.Products
            //     .Select(p => p)
            //     .Where(p => p.Color == "Silver")
            //     .First();
            //
            // var firstQ = Product.Products
            //     .Select(p => p)
            //     .Where(p => p.Color == "Silver")
            //     .First();

            // Product firstS = Product.Products
            //     .First(p => p.Color == "Silver");

            Product first = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Silver")
                .FirstOrDefault();

            Product firstOrDefault = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Silver")
                .FirstOrDefault();

            Product firstOrDefaultQ = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Belge")
                .FirstOrDefault();

            var firstOrDefaultS = Product.Products
                .FirstOrDefault(p => p.Color == "Belge");

            Product last = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Black")
                .Last();

            Product lastOrDefault = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Black")
                .LastOrDefault();

            Product lastOrDefaultS = Product.Products
                .LastOrDefault(p => p.Color == "Black");


            Product single = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Black" && p.Name == "uPhone X")
                .Single();

            Product singleOrDefault = Product.Products
                .Select(p => p)
                .Where(p => p.Color == "Black" && p.Name == "uPhone X")
                .SingleOrDefault();

            Product singleOrDefaultS = Product.Products
                .SingleOrDefault(p => p.Color == "Black" && p.Name == "uPhone X");

            Product singleOrDefaultQ =
                (from p in Product.Products
                    where p.Color == "Black" && p.Name == "uPhone X"
                 select p)
                .SingleOrDefault();

            List<Product> take = Product.Products
                .Select(p => p)
                .OrderBy(p => p.Id)
                .Take(2)
                .ToList();

            List<Product> takeQ = 
                (from p in Product.Products
                    orderby p.Id
                    select p)
                .Take(100)
                .ToList();


            List<Product> takeWhile = Product.Products
                .Select(p => p)
                .OrderBy(p => p.Id)
                .TakeWhile(p => !p.Name.StartsWith("uPad"))
                .ToList();

            List<Product> takeWhileQ =
                (from p in Product.Products
                    orderby p.Id
                    select p)
                .TakeWhile(p => !p.Name.StartsWith("uPad"))
                .ToList();

            List<Product> skipWhile = Product.Products
                .Select(p => p)
                .OrderBy(p => p.Id)
                .SkipWhile(p => p.Name.StartsWith("uPhone"))
                .ToList();

            List<Product> skip = Product.Products
                .Select(p => p)
                .OrderBy(p => p.Id)
                .Skip(2)
                .ToList();

            List<string> distinct = Product.Products
                .Select(p => p.Color)
                .Distinct()
                .ToList();

            List<string> distinctQ =
                (from p in Product.Products
                    select p.Color)
                .Distinct()
                .ToList();

            bool AreAllUProds = Product.Products
                .Select(p => p)
                .All(p => p.Name.StartsWith("u"));

            bool AreAllUProdsQ = 
                (from p in Product.Products
                 select p)
                .All(p => p.Name.StartsWith("u"));

            bool ExistsuPad = Product.Products
                .Select(p => p)
                .Any(p => p.Name.Contains("uPad"));

            bool ExistsuPadQ =
                (from p in Product.Products
                    select p)
                .Any(p => p.Name.Contains("uPad"));

            var contains = Product.Products
                .Select(p => p.Name)
                .Contains("uPad Air");


            bool containsQ =
                (from p in Product.Products
                    select p.Name)
                .Contains("uPadAir");

            Product newProduct = new Product()
            {
                Id = 1,
                Name = "uPhone X",
                Color = "Black",
                Price = 1200.99m,
                Cost = 800.10m
            };

            bool containsObj =
                Product.Products
                    .Select(p => p)
                    .Contains(newProduct); //false

            bool containsObjectC =
                Product.Products
                    .Select(p => p)
                    .Contains(newProduct, new ProductIdComparer()); //true

            Product ReferedProduct = Product.Products
                .Where(p => p.Id == 1)
                .Single();

            List<int> ints1 = new() { 1, 2, 3 };
            List<int> ints2 = new() { 1, 2, 3 };

            bool sequenceEqualVal = ints1.SequenceEqual(ints2); //true

            bool sequenceEqualRef = Product.Products.SequenceEqual(Product.ProductsCopy); //false
            bool sequenceEqualRefC = Product.Products.SequenceEqual(Product.ProductsCopy, new ProductIdComparer()); //true

            List<int> ints3 = new() { 0, 1, 2, 3, 4 };
            List<int> ints4 = new() { 1, 2, 3 };

            List<int> except = ints3.Except(ints4).ToList(); //0, 4

            List<Product> exceptRef = Product.Products
                .Except(Product.UPhonesOnlyList).ToList(); //Will include all products

            List<Product> exceptRefC = Product.Products
                .Except(Product.UPhonesOnlyList, new ProductIdComparer()).ToList(); //Will include all products except uPhones

            List<int> intersect = ints3.Intersect(ints4).ToList(); //1, 2, 3

            List<Product> intersectRef = Product.Products
                .Intersect(Product.UPhonesOnlyList).ToList(); //Will include nothing

            List<Product> intersectRefC = Product.Products
                .Intersect(Product.UPhonesOnlyList, new ProductIdComparer()).ToList(); //Will include uPhones only

            List<int> ints5 = new() { 1, 2, 3};
            List<int> ints6 = new() { 1, 5, 10 };

            List<int> concat = ints5.Concat(ints6).ToList(); //1, 2, 3, 1, 5, 10
            List<int> union = ints5.Union(ints6).ToList(); //1, 2, 3, 5, 10

            var join = Product.Products.Join(
                Product.Sale.Sales, 
                p => p.Id,
                s => s.ProductId,
                (p,s) => new
                {p.Id, p.Name, p.Color, p.Price, s.SaleId, s.Quantity})
                .ToList();

            var joinQ =
                (from p in Product.Products
                    join s in Product.Sale.Sales
                        on p.Id equals s.ProductId
                    select new
                    {
                        p.Id,
                        p.Name,
                        p.Color,
                        p.Price,
                        s.SaleId,
                        s.Quantity
                    })
                .ToList();

            var groupJoin = Product.Products.GroupJoin(
                Product.Sale.Sales,
                p => p.Id,
                s => s.ProductId,
                (p, s) => new
                {
                    Product = p,
                    Sales = s.ToList()
                }).ToList();

            var groupJoinQ = 
                (from p in Product.Products
                    join s in Product.Sale.Sales
                        on p.Id equals s.ProductId
                        into sales
                    select new
                {
                    Product = p,
                    Sales = sales.ToList()
                }).ToList();

            var groupBy = Product.Products
                .GroupBy(p => p.Color);

            var GroupByQ =
                (from p in Product.Products
                    group p by p.Color
                    into pByColor
                 select pByColor)
                .ToList();

            var groupByWhere = Product.Products
                .GroupBy(p => p.Color)
                .Where(p => p.Count() > 1)
                .ToList();

            var GroupByWhereQ =
                (from p in Product.Products
                    group p by p.Color
                    into pByColor
                    where pByColor.Count()>1
                    select pByColor)
                .ToList();

            int countQ = (from p in Product.Products
                            select p)
                        .Count(p => p.Name.StartsWith("uPad"));

            int count = Product.Products
                       .Count(p => p.Name.StartsWith("uPad"));

            decimal maxQ = (from p in Product.Products
                    select p.Price)
                .Max();

            decimal max = Product.Products
                .Max(p => p.Price);

            decimal SumQ = (from p in Product.Products
                    select p.Price)
                .Sum();

            decimal Sum = Product.Products
                .Sum(p => p.Price);

            var groupByWhereSumF = Product.Products
                .GroupBy(p => p.Color)
                .Where(p => p.Count() >= 1)
                .Select(p => new
                {
                    ProductColorGroup = p, 
                    SumOfPrices = p.Sum(p => p.Price)
                })
                .ToList();
          
     

            var GroupByWhereSum =
                (from p in Product.Products
                    group p by p.Color
                    into pByColor
                    where pByColor.Count() > 1
                    select new
                    {
                        ProductColorGroup = pByColor,
                        SumOfPrices = pByColor.Sum(p => p.Price)
                    })
                .ToList();

        }
    }
}
