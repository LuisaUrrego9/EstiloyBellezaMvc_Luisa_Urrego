using Microsoft.AspNetCore.Mvc;
using EstiloyBellezaMvc.Models;

namespace EstiloyBellezaMvc.Controllers
{
    public class CitasController : Controller
    {
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Cita cita)
        {
            if (string.IsNullOrEmpty(cita.Servicio))
            {
                ModelState.AddModelError("Servicio",
                    "Debes seleccionar un servicio.");
            }

            if (ModelState.IsValid)
            {
                return View("Confirmacion", cita);
            }

            return View("Registrar", cita);
        }
    }
}

