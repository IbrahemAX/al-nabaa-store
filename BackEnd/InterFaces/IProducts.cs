using al_nabaa_store.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace al_nabaa_store.BackEnd.InterFaces
{
    public interface IProducts
    {
        public Task<string> AddProducts(ProductsModels NewProducts);

        public Task<List<ProductsModels>> GetAllProducts();

        public Task<ProductsModels> GetProductDetails(int Id);

        public Task<string> EditProduct(ProductsModels NewProduct);


    }
}
