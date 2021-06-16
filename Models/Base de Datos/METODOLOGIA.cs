namespace SGCS_Bumer_Solutions.Models.Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

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

        public List<METODOLOGIA> ListarTodo()
        {
            var metodologia = new List<METODOLOGIA>();

            try
            {
                using (var db = new ModeloSGCS())
                {
                    metodologia = db.METODOLOGIA.ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return metodologia;
        }

        public void Guardar()
        {
            try
            {
                using (var db = new ModeloSGCS())
                {
                    if (this.ID_METODOLOGIA > 0)
                    {
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(this).State = EntityState.Added;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public METODOLOGIA ObtenerMetodologia(int id)
        {
            var metodologia = new METODOLOGIA();

            try
            {
                using (var db = new ModeloSGCS())
                {
                    metodologia = db.METODOLOGIA
                        .Where(x => x.ID_METODOLOGIA == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return metodologia;
        }

        public void Eliminar()
        {
            var metodologia = ObtenerMetodologia(ID_METODOLOGIA);
            this.ID_METODOLOGIA = metodologia.ID_METODOLOGIA;
            this.DESCRIPCION = metodologia.DESCRIPCION;
            this.ESTADO = true;
            try
            {
                using (var db = new ModeloSGCS())
                {
                    if (this.ID_METODOLOGIA > 0)
                    {
                        db.Entry(this).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Habilitar()
        {
            var metodologia = ObtenerMetodologia(ID_METODOLOGIA);
            this.ID_METODOLOGIA = metodologia.ID_METODOLOGIA;
            this.DESCRIPCION = metodologia.DESCRIPCION;
            this.ESTADO = true;
            try
            {
                using (var db = new ModeloSGCS())
                {
                    if (this.ID_METODOLOGIA > 0)
                    {
                        db.Entry(this).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
