using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccess
{

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool IsDiscontinued { get; set; }

        public Product() 
        {

        }
        public Product(int id, string name, decimal price = 0.0M, short stock = 0, bool discontinued = false)
        {
            ProductId = id;
            ProductName = name; 
            UnitPrice = price;
            UnitsInStock = stock;
            IsDiscontinued = discontinued;
        }
    }
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAllEntities();
        TEntity GetEntityBy(int id);
        void CreateNew(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
        int Count { get;  }
    }
    
}
