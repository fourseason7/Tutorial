using System.Web;
using System.Web.Mvc;

namespace TX_Eagle_Supply
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
