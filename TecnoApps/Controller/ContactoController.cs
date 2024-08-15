using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace TecnoApps.Controller
{
    public class ContactoController : ControllerBase
    {
        public IActionResult Contacto()
        {
            return RedirectToPage("Contacto");
        }
    }
}
