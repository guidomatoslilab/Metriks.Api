using Cloud.Metriks.Api.Model.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Interface.Repository.Persona
{
    public interface IPersonaRepository
    {
        PersonaEntity Buscar(string rut);
    }
}
