using Microsoft.AspNetCore.Mvc;

namespace Balanovici_Cristina_Lab1.Controllers
{
    public class ControllerLab : Controller
    {
        public IActionResult Index()
        {
            return Content("Bun venit"); 
        }

        public IActionResult Salut()
        {
            return Content("Salut");
        }

        public IActionResult SalutMesaj(string nume, int varsta)
        {
            return Content("Salut " +nume + " Ai " +varsta+" ani");
        }
    }
}
