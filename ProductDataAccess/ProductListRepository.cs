using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccess
{
    public class ProductListRepository : IRepository<Product>
    {
        static List<Product> productList = new List<Product>();

        public int Count { get => productList.Count; }
        

        public IEnumerable<Product> GetAllEntities()
        {
            return productList;
        }

        public void CreateNew(Product item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            var obj = GetEntityBy(item.ProductId);
            if(obj != null)
            {
                throw new Exception("item already exists");
            }
            productList.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetEntityBy(int id)
        {
           foreach(var item in productList)
            {
                if(item.ProductId==id) return item;
            }
            return null;
        }

        public void Update(Product item)
        {
            if(item == null) {  throw new ArgumentNullException("item"); }
            var obj = GetEntityBy(item.ProductId);
            if(obj == null) 
            {
                throw new Exception("Item does not exist");
            }
            productList.Remove(obj);
            productList.Add(item);
        }
    }
}
