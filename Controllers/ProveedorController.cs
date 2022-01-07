using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proveedoresLECH.Models;

namespace proveedoresLECH.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult Index()
        {
            List<ProveedoresCLS> listaProovedor = null;
            using (var bd = new proveedoresBDEntities())
            {
                listaProovedor = (from captura in bd.Proveedores
                                  select new ProveedoresCLS
                                  {
                                      iidProveedor = captura.Id_Proveedor,
                                      codigo = captura.Codigo,
                                      razonSocial = captura.Razon_Social,
                                      rfc = captura.RFC
                                  }
                                ).ToList();
            }
            return View(listaProovedor);
            
        }
    }
}