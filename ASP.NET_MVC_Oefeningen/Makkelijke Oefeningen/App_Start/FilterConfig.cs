using System.Web;
using System.Web.Mvc;

namespace Makkelijke_Oefeningen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
