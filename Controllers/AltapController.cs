using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proveedoresLECH.Models;

namespace proveedoresLECH.Controllers
{
    public class AltapController : Controller
    {
        // GET: Altap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agrega(ProveedoresCLS oProveedoresCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oProveedoresCLS);
            }
            else
            {
                using (var bd = new proveedoresBDEntities())
                {
                    Proveedores oProveedores = new Proveedores();
                    oProveedores.Codigo = oProveedoresCLS.codigo;
                    oProveedores.Razon_Social = oProveedoresCLS.razonSocial;
                    oProveedores.RFC = oProveedoresCLS.rfc;
                    bd.Proveedores.Add(oProveedores);
                    bd.SaveChanges();
                }
            }
                return RedirectToAction("Index", "Proveedor");
        }
    }
}