namespace SGCS_Bumer_Solutions.Models.Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETAPA")]
    public partial class ETAPA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ETAPA()
        {
            ENTREGABLE = new HashSet<ENTREGABLE>();
        }

        [Key]
        public int ID_ETAPA { get; set; }

        [Required]
        [StringLength(40)]
        public string NOMBRE { get; set; }

        public int ID_METODOLOGIA { get; set; }

        public bool? ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTREGABLE> ENTREGABLE { get; set; }

        public virtual METODOLOGIA METODOLOGIA { get; set; }
    }
}
