using System;
using System.Web.Mvc;

namespace _01_AntiForgeryTokenWithAjax.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public PartialViewResult NowWithGET()
		{
			return PartialView("TestLinkResult", DateTime.Now);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public PartialViewResult NowWithToken()
		{
			return PartialView("TestLinkResult", DateTime.Now);
		}
	}
}