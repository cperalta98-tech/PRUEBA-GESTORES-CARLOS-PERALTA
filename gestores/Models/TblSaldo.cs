using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace gestores.Models
{
    [Table("tblSaldo")]
    public partial class TblSaldo
    {
        public TblSaldo()
        {
            TblGestorSaldoDetalle = new HashSet<TblGestorSaldoDetalle>();
        }

        [Key]
        public int IdSaldo { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Monto { get; set; }
        public bool? Activo { get; set; }

        [InverseProperty("IdSaldoNavigation")]
        public virtual ICollection<TblGestorSaldoDetalle> TblGestorSaldoDetalle { get; set; }
    }
}
