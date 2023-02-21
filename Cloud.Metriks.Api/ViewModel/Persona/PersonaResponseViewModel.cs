using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.ViewModel.Persona
{
    public class PersonaResponseViewModel
    {
        public int Id { get; set; }
        public string? RazonSocial { get; set; }
        public bool Cliente { get; set; }
        public bool Deudor { get; set; }
        public string? RutEjecutivo { get; set; }
        public string? EstadoCliente { get; set; }
        public string? EstadoDeudor { get; set; }
    }
}
