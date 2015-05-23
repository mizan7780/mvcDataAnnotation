using System.Web;
using System.Web.Mvc;

namespace MvcDataAnnotation_validation_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}