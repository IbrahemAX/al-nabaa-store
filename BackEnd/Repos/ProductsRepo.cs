using al_nabaa_store.BackEnd.InterFaces;
using al_nabaa_store.Data;
using al_nabaa_store.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace al_nabaa_store.BackEnd.Repos
{
    public class ProductsRepo : IProducts
    {
        private readonly ApplicationDbContext _db;
        public ProductsRepo(ApplicationDbContext dbContext) // constructor
        {
            _db = dbContext; 
        }
        public async Task<string> AddProducts(ProductsModels NewProducts)
        {
           await _db.ProductsTable.AddAsync(NewProducts);
            await _db.SaveChangesAsync();
            return "تمت اضافة المنتج";
        }

        public async Task<string> EditProduct(ProductsModels NewProduct)
        {
            var OldProduct = await _db.ProductsTable.SingleOrDefaultAsync(a=>a.Id == NewProduct.Id);
            OldProduct = NewProduct;
            _db.ProductsTable.Update(OldProduct);
            await _db.SaveChangesAsync();
            return "تم تعديل المنتج بنجاح";
        }

        public async Task<List<ProductsModels>> GetAllProducts()
        {
            return await _db.ProductsTable.ToListAsync();

        }

        public async Task<ProductsModels> GetProductDetails(int Id)
        {
            return await _db.ProductsTable.SingleOrDefaultAsync(a => a.Id == Id);
        }
    }
}
