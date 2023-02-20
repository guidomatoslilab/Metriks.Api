using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Model.Entity.Persona
{
    public class PersonaEntity
    {
        public int prg_int_idpersona { get; set; }
        public string? prg_vch_rut { get; set; }
        public string? prg_vch_razonsocial { get; set; }
        public string? prg_vch_nombre { get; set; }
        public int prg_int_idtipo { get; set; }
    }
}
