using Cloud.Metriks.Api.Model.Contract.Persona;
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
        PersonaResponseDto Buscar(string rut);
    }
}
