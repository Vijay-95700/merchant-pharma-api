using Microsoft.AspNetCore.Mvc;

namespace PharmacyCollege.Api.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
