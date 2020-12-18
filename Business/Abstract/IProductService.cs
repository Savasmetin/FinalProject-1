using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategoryId(int categoryId);
        List<ProductWithCategoryDto> GetProductsByCategoryName(string categoryName);
        List<Product> GetProductsByUnitPrice(decimal min, decimal max);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);


    }
}
