using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.ViewModel.Persona
{
    public class LineaResponseViewModel
    {
        public decimal LineaAutorizada { get; set; }
        public decimal LineaDisponible { get; set; }
        public string? FechaAprobacion { get; set; }
        public string? FechaVencimiento { get; set; }
        public string? Estado { get; set; }
        public string? Vigente { get; set; }
    }
}
