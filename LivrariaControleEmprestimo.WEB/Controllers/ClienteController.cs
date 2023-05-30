using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListClient = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListClient);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            oClienteService.oRepositoryCliente.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(oCliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(oCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.Alterar(model);
            int id = oCliente.Id;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oClienteService.oRepositoryCliente.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
