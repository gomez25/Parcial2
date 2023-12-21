using Microsoft.AspNetCore.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class RectanguloController : Controller
    {
        public IActionResult Index()
        {
            return View(new RectanguloModel());
        }


        [HttpPost]
        public IActionResult Calcular(RectanguloModel model)
        {
            ViewBag.Results = new Dictionary<string, object>();

            if (ModelState.IsValid)
            {
                if (model.Validar)
                {
                    ViewBag.Results["ResultadoRectangulo"] = $"Área: {model.Largo * model.Ancho}";
                }
                else
                {
                    ViewBag.Results["ResultadoRectangulo"] = $"Perímetro: {(2 * model.Largo) + (2 * model.Ancho)}";
                }
                return View("Index", model);
            }
            return View("Index", model);
        }
    }
}
