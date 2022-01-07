using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proveedoresLECH.Models
{
    public class ProveedoresCLS
    {        
        [Display(Name ="ID Proveedor")]
        public long iidProveedor {get;set;}
        [Required]
        [Display(Name = "Codigo Proveedor")]
        public string codigo { get; set; }
        [Required]
        [Display(Name = "Razon Social")]
        public string razonSocial { get; set; }
        [Required]
        [Display(Name = "RFC")]
        public string rfc { get; set; }
    }
}