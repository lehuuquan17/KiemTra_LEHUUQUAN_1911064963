using System.Web;
using System.Web.Mvc;

namespace KiemTra_LEHUUQUAN_1911064963
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
