
using DucTC3.NWEB.Practice.T02.Core.Models;

namespace DucTC3.NWEB.Practice.T02.DataAccessLayer.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        //public Category GetByUrlSlug(string urlSlug)
        //{
        //    var category = MyDbSet.FirstOrDefault(c => c.UrlSlug == urlSlug);
        //    return category;
        //}
    }
}
