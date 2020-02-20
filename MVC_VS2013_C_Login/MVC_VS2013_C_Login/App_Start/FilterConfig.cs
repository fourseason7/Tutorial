using System.Web;
using System.Web.Mvc;

namespace MVC_VS2013_C_Login
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}