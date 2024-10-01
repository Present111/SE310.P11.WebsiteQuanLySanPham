using System.Web;
using System.Web.Mvc;

namespace SE310.P11.WebsiteQuanLySanPham
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
