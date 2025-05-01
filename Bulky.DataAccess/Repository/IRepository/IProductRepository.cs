using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        // This interface inherits from the generic IRepository interface for the Product model.
        // It can be extended with additional methods specific to Product if needed.
        void Update(Product obj);
    }
   
    
}
