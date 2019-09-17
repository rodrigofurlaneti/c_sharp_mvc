using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente { id = 1, nome_cliente = "Rodrigo Luiz", celular_cliente = "11995882409" });
            clientes.Add(new Cliente { id = 2, nome_cliente = "José Luiz", celular_cliente = "11995882499" });
            return View(clientes);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}