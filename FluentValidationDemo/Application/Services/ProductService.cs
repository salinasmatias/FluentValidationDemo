using Application.Repositories;
using Application.Services.Contracts;
using Domain;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public void DeleteProduct(Guid id)
        {
            _repository.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts(int pageNumber = 1, int pageSize = 5, string? filter = null)
        {
            return _repository.GetAllProducts(pageNumber, pageSize, filter);
        }

        public Product? GetProductById(Guid id)
        {
            return _repository.GetProductById(id);
        }

        public void UpdateProduct(Guid id, Product product)
        {
            _repository.UpdateProduct(id, product);
        }
    }
}
