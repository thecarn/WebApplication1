using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models.Models;

namespace WebApplication.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        //TODO: ADD MORE SPECIFIC FUNCTIONALITY
        void Update(Product obj);



    }
}
