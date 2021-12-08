using Bufa.Web.Models;
using System.Threading.Tasks;

namespace Bufa.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();

        Task<T> GetAllProductByIdAsync<T>(int id);

        Task<T> CreateProductAsync<T>(ProductDto productDto);

        Task<T> UpdateProductAsync<T>(ProductDto productDto);

        Task<T> DeleteProductAsync<T>(int id);
    }
}