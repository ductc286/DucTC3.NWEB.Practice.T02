using DucTC3.NWEB.Practice.T02.Core.Models;
using NWEB.Practice.T02.DataAccessLayer;

namespace DucTC3.NWEB.Practice.T02.DataAccessLayer.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //Category GetByUrlSlug(string urlSlug);
    }
}
