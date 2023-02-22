using System.ComponentModel.DataAnnotations;

namespace Cloud.Metriks.Api.Model.Entity
{
    public class AuditBase : EntityBase
    {
        [MaxLength(15)]
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        [Required]
        public bool Activo { get; set; } = true;
    }
}
