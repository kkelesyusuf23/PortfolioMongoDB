using Microsoft.AspNetCore.Mvc;

namespace PortfolioMongoDB.Controllers
{
    public class ContactInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
