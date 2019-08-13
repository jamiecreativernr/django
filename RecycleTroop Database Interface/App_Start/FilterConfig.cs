using System.Web;
using System.Web.Mvc;

namespace RecycleTroop_Database_Interface
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
