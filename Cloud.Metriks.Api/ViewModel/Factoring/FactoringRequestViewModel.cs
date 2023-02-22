using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.ViewModel.Factoring
{
    public class FactoringRequestViewModel
    {
        public string? RutCliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? IdCanal { get; set; }
        public string? Estado { get; set; }
        public string? FechaOperacion { get; set; }
        public decimal PorcentajeAnticipo { get; set; }
        public decimal TasaOperacion { get; set; }
        public decimal ComisionOperacionFija { get; set; }
        public decimal ComisionOperacionVariable { get; set; }
        public decimal MontoOperacion { get; set; }
        public decimal MontoAnticipable { get; set; }
        public decimal DiferenciaPrecio { get; set; }
        public string? BancoAbono { get; set; }
        public string? NumeroCuentaAbono { get; set; }
        public List<DocumentoRequestViewModel>? Documentos { get; set; }
    }
}
