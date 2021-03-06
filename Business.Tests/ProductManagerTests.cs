using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        public void AddTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var productToAdd = new Product { CategoryId = 2, ProductName = "Acer Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 2000, UnitsInStock = 3 };
            IResult result1 = productManager.Add(productToAdd);
            Assert.AreEqual(true, result1.Success);

            productToAdd.ProductName = "a";
            IResult result2 = productManager.Add(productToAdd);
            Assert.AreEqual(false, result2.Success);

        }
    }
}
