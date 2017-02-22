using System.Web;
using System.Web.Mvc;
using Common.Web.Filters;

namespace AdminCenter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthAttribute());
        }
    }
}
