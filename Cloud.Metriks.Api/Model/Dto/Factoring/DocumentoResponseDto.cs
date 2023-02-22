using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Model.Dto.Factoring
{
    public class DocumentoResponseDto
    {
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? RutDeudor { get; set; }
        public string? NombreDeudor { get; set; }
        public string? FechaVencimientoDocumento { get; set; }
        public decimal MontoDocumento { get; set; }
        public decimal MontoAnticipable { get; set; }
        public decimal DiferenciaPrecio { get; set; }
    }
}
