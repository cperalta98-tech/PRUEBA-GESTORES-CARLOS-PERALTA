using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace gestores.Models
{
    [Table("tblGestorSaldoDetalle")]
    public partial class TblGestorSaldoDetalle
    {
        [Key]
        public int IdGestorSaldoDetalle { get; set; }
        public int? IdGestor { get; set; }
        public int? IdSaldo { get; set; }
        public bool? Activo { get; set; }

        [ForeignKey(nameof(IdGestor))]
        [InverseProperty(nameof(TblGestore.TblGestorSaldoDetalle))]
        public virtual TblGestore IdGestorNavigation { get; set; }
        [ForeignKey(nameof(IdSaldo))]
        [InverseProperty(nameof(TblSaldo.TblGestorSaldoDetalle))]
        public virtual TblSaldo IdSaldoNavigation { get; set; }
    }
}
