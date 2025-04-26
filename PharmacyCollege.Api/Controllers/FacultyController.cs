using Microsoft.AspNetCore.Mvc;

namespace PharmacyCollege.Api.Controllers
{
    public class FacultyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
