using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
