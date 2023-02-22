using AutoMapper;
using Cloud.Metriks.Api.Interface.Service.Empleado;
using Cloud.Metriks.Api.Interface.Service.Persona;
using Cloud.Metriks.Api.Model.Dto.Empleado;
using Cloud.Metriks.Api.ViewModel.Empleado;
using Cloud.Metriks.Api.ViewModel.Persona;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly IEmpleadoService _empleadoService;
        private readonly IMapper _mapper;

        public EmpleadoController(IEmpleadoService empleadoService, IMapper mapper)
        {
            _empleadoService = empleadoService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("[action]/{rut}")]
        public ActionResult Buscar(string rut)
        {
            EmpleadoResponseDto empleadoResponseDto = _empleadoService.Buscar(rut);

            EmpleadoResponseViewModel response = _mapper.Map<EmpleadoResponseViewModel>(empleadoResponseDto);

            return Ok(response);
        }   
    }
}
