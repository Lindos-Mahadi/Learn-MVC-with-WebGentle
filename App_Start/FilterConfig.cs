using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
