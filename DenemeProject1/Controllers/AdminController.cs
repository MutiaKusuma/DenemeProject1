using Microsoft.AspNetCore.Mvc;

namespace DenemeProject1.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
