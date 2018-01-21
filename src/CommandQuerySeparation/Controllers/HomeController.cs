using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CommandQuerySeparation.Models;
using CommandQuerySeparation.Queries;

namespace CommandQuerySeparation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryProcessor _queryProcessor;

        public HomeController(IQueryProcessor queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }

        public IActionResult Index()
        {
            var findUserbyIdQuery = new FindUserByIdQuery
            {
                Id = "1"
            };

            var user = _queryProcessor.Process(findUserbyIdQuery);

            return View(user);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
