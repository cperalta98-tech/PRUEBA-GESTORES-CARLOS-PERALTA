using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace gestores.Models
{
    [Table("tblGestore")]
    public partial class TblGestore
    {
        public TblGestore()
        {
            TblGestorSaldoDetalle = new HashSet<TblGestorSaldoDetalle>();
        }

        [Key]
        public int IdGestor { get; set; }
        [StringLength(50)]
        public string Gestor { get; set; }
        public bool? Activo { get; set; }

        [InverseProperty("IdGestorNavigation")]
        public virtual ICollection<TblGestorSaldoDetalle> TblGestorSaldoDetalle { get; set; }
    }
}
