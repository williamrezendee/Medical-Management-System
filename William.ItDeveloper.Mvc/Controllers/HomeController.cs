using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using William.ItDeveloper.Mvc.Models;

namespace William.ItDeveloper.Mvc.Controllers
{
	[Route("")]
	[Route("home-page")]
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		[Route("index")]
		public IActionResult Index()
		{
			return View();
		}

		[Route("")]
		[Route("dashboard")]
		public IActionResult Dashboard()
		{
			return View();
		}

		[Route("privacy")]
		[Route("privacy-policy")]
		public IActionResult Privacy()
		{
			return View();
		}

		[Route("errors")]
		[Route("errors-control")]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}