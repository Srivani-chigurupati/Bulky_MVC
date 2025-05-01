using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //This interface will have all the methods of the IRepository interface
        //and any additional methods specific to the Category entity
        void Update(Category category);
        //void Save();
    }
    
}
