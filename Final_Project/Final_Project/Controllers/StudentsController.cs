using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
