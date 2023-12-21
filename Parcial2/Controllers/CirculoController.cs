using Microsoft.AspNetCore.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers;

public class CirculoController : Controller
{
    public IActionResult Index()
    {
        return View(new CirculoModel());
    }


    [HttpPost]
    public IActionResult Calcular(CirculoModel model)
    {
        ViewBag.Results = new Dictionary<string, object>();
        if (ModelState.IsValid)
        {
            if (model.Validar)
            {
                ViewBag.Results["ResultadoCirculo"] = $"Área {3.14f * (model.Radio * model.Radio)}";
            }
            else
            {
                ViewBag.Results["ResultadoCirculo"] = $"Perimetro {2 * 3.14f * model.Radio}";
            }
            return View("Index", model);
        }
        return View("Index", model);
    }
}