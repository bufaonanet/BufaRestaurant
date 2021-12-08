using Bufa.Services.Api.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bufa.Services.Api.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();

        Task<ProductDto> GetProductById(int productId);

        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);

        Task<bool> DeleteProduct(int productId);
    }
}