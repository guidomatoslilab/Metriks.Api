using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Dto.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Interface.Repository.Empleado
{
    public interface IEmpleadoRepository
    {
        EmpleadoResponseDto Buscar(string rut);
    }
}
