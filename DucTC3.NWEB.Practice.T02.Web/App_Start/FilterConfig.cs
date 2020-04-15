using System.Web;
using System.Web.Mvc;

namespace DucTC3.NWEB.Practice.T02.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
