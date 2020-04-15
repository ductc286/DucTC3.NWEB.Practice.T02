using DucTC3.NWEB.Practice.T02.Core.Models;
using NWEB.Practice.T02.DataAccessLayer;
using System.Linq;

namespace DucTC3.NWEB.Practice.T02.DataAccessLayer.Repositories
{
    public class FlowerRepository : GenericRepository<Flower>, IFlowerRepository
    {
        public IQueryable<Flower> GetByCategory(int categoryId)
        {
            return MyDbSet.Where(p => p.Category.CategoryId == categoryId).OrderByDescending(p => p.CategoryId);
        }
    }
}
