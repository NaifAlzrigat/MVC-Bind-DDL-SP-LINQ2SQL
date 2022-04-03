using System.Web;
using System.Web.Mvc;

namespace MVC_Bind_DDL_SP_LINQ2SQL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
