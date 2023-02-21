using Cloud.Metriks.Api.Model.Contract.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Interface.Service.Persona
{
    public interface IPersonaService
    {
        PersonaResponseDto Buscar(string rut);
    }
}
