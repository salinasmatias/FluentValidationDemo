using Application.Repositories;
using Domain;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository()
        {
            _context = new Context();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(Guid id)
        {
            var product = _context.Products.First(p => p.Id == id);
            _context.Products.Remove(product);
        }

        public IEnumerable<Product> GetAllProducts(int pageNumber = 1, int pageSize = 5, string? filter = null)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                return _context.Products.Where(p => p.Name.Contains(filter, StringComparison.OrdinalIgnoreCase)).Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            }

            return _context.Products.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        }

        public Product? GetProductById(Guid id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Guid id, Product product)
        {
            foreach (var item in _context.Products)
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
