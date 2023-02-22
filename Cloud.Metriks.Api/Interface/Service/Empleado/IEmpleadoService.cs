using Cloud.Metriks.Api.Model.Dto.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Interface.Service.Empleado
{
    public interface IEmpleadoService
    {
        EmpleadoResponseDto Buscar(string rut);
    }
}
