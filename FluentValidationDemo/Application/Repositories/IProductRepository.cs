using Domain;

namespace Application.Repositories
{
    public interface IProductRepository
    {
        public Product? GetProductById(Guid id);
        public IEnumerable<Product> GetAllProducts(int pageNumber = 1, int pageSize = 5, string? filter = null);
        public void AddProduct(Product product);
        public void UpdateProduct(Guid id, Product product);
        public void DeleteProduct(Guid id);
    }
}
