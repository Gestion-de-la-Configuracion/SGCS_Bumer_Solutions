namespace SGCS_Bumer_Solutions.Models.Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("METODOLOGIA")]
    public partial class METODOLOGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public METODOLOGIA()
        {
            ETAPA = new HashSet<ETAPA>();
            PROYECTO = new HashSet<PROYECTO>();
        }

        [Key]
        public int ID_METODOLOGIA { get; set; }

        [StringLength(20)]
        public string DESCRIPCION { get; set; }

        public bool? ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPA> ETAPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROYECTO> PROYECTO { get; set; }
    }
}
