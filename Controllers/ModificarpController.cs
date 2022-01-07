using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proveedoresLECH.Models;

namespace proveedoresLECH.Controllers
{
    public class ModificarpController : Controller
    {
        // GET: Modificarp
        public ActionResult Index(int id)
        {
            ProveedoresCLS oProveedorCLS = new ProveedoresCLS();
            using (var bd = new proveedoresBDEntities())
            {
                Proveedores oProveedor = bd.Proveedores.Where(p => p.Id_Proveedor.Equals(id)).First();
                oProveedorCLS.iidProveedor = oProveedor.Id_Proveedor;
                oProveedorCLS.codigo = oProveedor.Codigo;
                oProveedorCLS.razonSocial = oProveedor.Razon_Social;
                oProveedorCLS.rfc = oProveedor.RFC;

            }
            return View(oProveedorCLS);
        }
        [HttpPost]
        public ActionResult Index(ProveedoresCLS oProveedorCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oProveedorCLS);
            }
            else
            {
                long idProv = oProveedorCLS.iidProveedor;
                using (var bd = new proveedoresBDEntities())
                {
                    Proveedores oProveedor = bd.Proveedores.Where(p => p.Id_Proveedor.Equals(idProv)).First();
                    oProveedor.Codigo = oProveedorCLS.codigo;
                    oProveedor.Razon_Social = oProveedorCLS.razonSocial;
                    oProveedor.RFC = oProveedorCLS.rfc;
                    bd.SaveChanges().ToString();
                }
            }
            return RedirectToAction("Index", "Proveedor");
        }
    }
}