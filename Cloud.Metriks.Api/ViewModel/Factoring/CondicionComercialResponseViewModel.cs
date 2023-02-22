﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.ViewModel.Factoring
{
    public class CondicionComercialResponseViewModel
    {
        public decimal PorcentajeAnticipo { get; set; }
        public decimal Tasa { get; set; }
        public decimal TipoComisionFija { get; set; }
        public decimal MonedaComisionFija { get; set; }
        public decimal ValorComisionFija { get; set; }
        public decimal ComisionVariable { get; set; }
    }
}
