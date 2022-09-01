using ExempelProject.Data.Entities;
using System.Text.Json;

namespace ExempelProject.Data
{
    public class ExempelSeeder
    {
        private readonly ExempelProjectContext ctx;
        private readonly IWebHostEnvironment hosting;

        public ExempelSeeder(ExempelProjectContext ctx, IWebHostEnvironment hosting)
        {
            this.ctx = ctx;
            this.hosting = hosting;
        }
        public void Seed()
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Products.Any())
            {
                //Need to create sample data
                var file = Path.Combine(hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(file);
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);
                ctx.Products.AddRange(products);

                var order = ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                if (order != null)
                {
                    order.Items = new List<OrderItem>()
                    {
                       new OrderItem()
                       {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                       }
                    };
                }

                ctx.SaveChanges();

            }
        }
    }
}
