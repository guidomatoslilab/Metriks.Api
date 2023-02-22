using Cloud.Metriks.Api.Interface.Repository.Empleado;
using Cloud.Metriks.Api.Interface.Service.Empleado;
using Cloud.Metriks.Api.Model.Dto.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Service.Empleado
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public EmpleadoResponseDto Buscar(string rut)
        {
            EmpleadoResponseDto empleado = _empleadoRepository.Buscar(rut);
            return empleado;
        }
    }
}
