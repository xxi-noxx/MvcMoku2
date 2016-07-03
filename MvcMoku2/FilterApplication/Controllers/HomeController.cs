using FilterApplication.Models.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			var model = new IndexViewModel();
			model.SetDisplayValue();
			return View(model);
        }

		public ActionResult ErrorPage()
		{
			throw new HttpException(400, "400エラーだじょー");
		}
    }
}