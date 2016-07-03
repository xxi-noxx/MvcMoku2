using FilterApplication.Filter;
using System.Web.Mvc;

namespace FilterApplication
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorExAttribute());
		}
	}
}