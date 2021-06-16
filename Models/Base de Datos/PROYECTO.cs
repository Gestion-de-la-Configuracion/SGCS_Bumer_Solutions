namespace SGCS_Bumer_Solutions.Models.Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("PROYECTO")]
    public partial class PROYECTO
    {
        [Key]
        public int ID_PROYECYO { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(60)]
        public string DESCRIPCION { get; set; }

        public int ID_CLIENTE { get; set; }

        public int ID_METODOLOGIA { get; set; }

        public bool? ESTADO { get; set; }

        public int ID_JEFEPROYECTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_FIN { get; set; }

        public virtual METODOLOGIA METODOLOGIA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }


        public List<PROYECTO> ListarTodo()
        {
            var proyecto = new List<PROYECTO>();

            try
            {
                using (var db = new ModeloSGCS())
                {
                    proyecto = db.PROYECTO.Include("METODOLOGIA")
                        .Include("USUARIO")
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return proyecto;
        }

        public void Guardar()
        {
            try
            {
                using (var db = new ModeloSGCS())
                {
                    if (this.ID_PROYECYO > 0)
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
    }
}
