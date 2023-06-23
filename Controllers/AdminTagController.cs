using BlogProject.Models;
using BlogProject.Models.Domain;
using BlogProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace BlogProject.Controllers
{
    public class AdminTagController : Controller
    {
        private ApplicationDbContext applicationDbContext;
        // call dbconext here
        public AdminTagController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
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

        // method to handle the button click
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            // Add model to the database
            this.applicationDbContext.Tags.Add(tag);
            // add this line to save the changes
            this.applicationDbContext.SaveChanges();
            return View("Add");
        }
    }
}
