using System.ComponentModel.DataAnnotations;

namespace Cloud.Metriks.Api.Model.Entity
{
    public class EntityBase
    {
        [MaxLength(15)]
        public string UsuarioRegistra { get; set; }
        public DateTime FechaRegistra { get; set; }
    }
}
