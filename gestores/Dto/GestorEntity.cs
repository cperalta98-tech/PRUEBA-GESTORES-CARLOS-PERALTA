using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gestores.Dto
{
    public class GestorEntity
    {
        public GestorEntity()
        {
            gestorSaldoDetalleEntities = new List<GestorSaldoDetalleEntity>();
        }
        [Key]
        public int IdGestor { get; set; }
        [StringLength(50)]
        public string Gestor { get; set; }
        public bool? Activo { get; set; }

        public List<GestorSaldoDetalleEntity> gestorSaldoDetalleEntities { get; set; }
    }
}