using Application.Repositories;
using Domain;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            Context.Products.Add(product);
        }

        public void DeleteProduct(Guid id)
        {
            var product = Context.Products.First(p => p.Id == id);
            Context.Products.Remove(product);
        }

        public IEnumerable<Product> GetAllProducts(int pageNumber = 1, int pageSize = 5, string? filter = null)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                return Context.Products.Where(p => p.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)).Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            }

            return Context.Products.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        }

        public Product? GetProductById(Guid id)
        {
            return Context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Guid id, Product product)
        {
            foreach (var item in Context.Products)
            {
                if (item.Id == id)
                {
                    item.Name = product.Name;
                    item.Description = product.Description;
                    item.Category = product.Category;
                    item.Stock = product.Stock;
                }
            }
        }
    }
}
