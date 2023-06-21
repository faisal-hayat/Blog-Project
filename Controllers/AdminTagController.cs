using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class AdminTagController : Controller
    {
        // This is the default View
        // If nor veiw is nentioned in the route, this will be applied
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
