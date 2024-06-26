using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gestores.Dto
{
    public class GestorSaldoDetalleEntity
    {
        [Key]
        public int IdGestorSaldoDetalle { get; set; }
        public int? IdGestor { get; set; }
        public int? IdSaldo { get; set; }
        public decimal Monto { get; set; }
        public bool? Activo { get; set; }
    }
}