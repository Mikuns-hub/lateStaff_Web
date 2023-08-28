using Microsoft.AspNetCore.Mvc;

namespace ololade_web.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
