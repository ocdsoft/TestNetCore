using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using TestNetCore.ViewModels.Home;

namespace TestNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            //Debugger.Launch();
            var viewModel = new AboutViewModel();
            viewModel.Heading = "CIS Dev Team";
            viewModel.Developers.Add(new Models.Developer() { Name = "Greg Hardin", Specialty = "Back End Master, Ideator, Knowledge Connoisseur" });
            viewModel.Developers.Add(new Models.Developer() { Name = "Ben Funkhouser", Specialty = "Front End Master, Fuel Efficient, Communicaton Aficionado" });
            viewModel.Developers.Add(new Models.Developer() { Name = "Ted Bergeron", Specialty = "Documentarian, Artist, Designer" });
            
            return View(viewModel);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
