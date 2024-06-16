using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccessTests
{
    [TestClass]
    public class ProductListRepositoryTests
    {
        [TestMethod]
        public void TestFor_Count_Property_TheFirstTime()
        {
            IRepository<Product> repository = new ProductListRepository();
            int expected = 0;

            int actual = repository.Count;
            Assert.AreEqual(expected, actual);
        }

        //Behavioral Testing
        [TestMethod]
        public void TestFor_CreateNewProduct_ValidValues()
        {
            Product product = new Product(101,"1",122M,321,false);
            IRepository<Product> repository = new ProductListRepository();
            int prevCount = repository.Count;

            //Act
            repository.CreateNew(product);
            int currentCount = repository.Count;
            Assert.AreEqual(prevCount + 1, currentCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFor_CreateNewProduct_NullValues()
        {
            Product product = null;
            IRepository<Product> repository = new ProductListRepository();
            //int prevCount = repository.Count;

            //Act
            repository.CreateNew(product);
            repository.CreateNew(product);
            //int currentCount = repository.Count;
            //Assert.AreEqual(prevCount, currentCount);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFor_CreateNewProduct_WithDuplicate()
        {
            Product product = new Product(101,"sample",101m,1,false);
            IRepository<Product> repository = new ProductListRepository();
            //int prevCount = repository.Count;

            //Act
            repository.CreateNew(product);
            repository.CreateNew(product);
            //int currentCount = repository.Count;
            //Assert.AreEqual(prevCount, currentCount);
        }
        [TestMethod]
        public void TestFor_GetEntityBy_WithValid()
        {
            //Arrange
            Product product = new Product(110, "Product 1", 123m, 321, false);
            IRepository<Product> repository = new ProductListRepository();

            //insert the product and then we can retrieve it
            repository.CreateNew(product);

            var acutalObj = repository.GetEntityBy(product.ProductId);

            Assert.AreEqual(product.ProductName,acutalObj.ProductName);
            Assert.AreEqual(product.UnitPrice, acutalObj.UnitPrice);
        }
        [TestMethod]
        public void TestFor_GetEntityBy_WithInValid()
        {
            //Product product = new Product(110, "Product 1", 123m, 321, false);
            IRepository<Product> repository = new ProductListRepository();

            //insert the product and then we can retrieve it
            //repository.CreateNew(product);

            var acutalObj = repository.GetEntityBy(-1);

            Assert.IsNull(acutalObj);
        }
        [TestMethod]
        public void TestFor_UpdateEntity_WithValidValues()
        {
            IRepository<Product> repository = new ProductListRepository();
            TestFor_CreateNewProduct_ValidValues();
            Product item = repository.GetAllEntities().ToList()[0];
            Product updateObject = new Product(item.ProductId, item.ProductName, item.UnitPrice, item.UnitsInStock, item.IsDiscontinued);
            updateObject.ProductName = "Hello world";
            updateObject.UnitPrice = 3332m;
            repository.Update(updateObject);

            item = repository.GetEntityBy(updateObject.ProductId);

            Assert.AreEqual(updateObject.ProductName, item.ProductName);
            Assert.AreEqual(updateObject.UnitPrice, item.UnitPrice);
        }
    }
}
