using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryId==categoryId);
        }

        public List<ProductWithCategoryDto> GetProductsByCategoryName(string categoryName)
        {
            return _productDal.GetProductsWithCategoryName(categoryName);
        }

        public List<Product> GetProductsByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetList(p => p.UnitPrice >=min && p.UnitPrice<=max);
        }

        public void Update(Product product)
        {
            return _productDal.Update(product,);
        }
    }
}
