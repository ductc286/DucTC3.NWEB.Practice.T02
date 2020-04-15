using DucTC3.NWEB.Practice.T02.Core.Models;
using System.Linq;

namespace NWEB.Practice.T02.DataAccessLayer
{
    public interface IFlowerRepository : IGenericRepository<Flower>
    {
        IQueryable<Flower> GetByCategory(int categoryId);
    }
}
