using AutoMapper;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Interface.Service.Persona;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Dto.Empleado;
using Cloud.Metriks.Api.Model.Dto.Persona;
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
    public class PersonaController : ControllerBase
    {

        private readonly IPersonaService _personaService;
        private readonly IMapper _mapper;

        public PersonaController(IPersonaService personaService, IMapper mapper)
        {
            _personaService = personaService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("[action]/{rut}")]
        public ActionResult Buscar(string rut)
        {
            PersonaResponseDto personaResponseDto = _personaService.Buscar(rut);

            PersonaResponseViewModel response = _mapper.Map<PersonaResponseViewModel>(personaResponseDto);

            return Ok(response);
        }



        [HttpGet]
        [Route("[action]/{rut}")]
        public ActionResult ObtenerLineas(string rut)
        {
            //EmpleadoResponseDto empleadoResponseDto = _personaService.Buscar(rut);

            //EmpleadoResponseViewModel response = _mapper.Map<EmpleadoResponseViewModel>(empleadoResponseDto);

            //return Ok(response);
            return Ok();
        }



        [HttpGet]
        [Route("[action]/{rut}")]
        public ActionResult ObtenerSubLineas(string rut)
        {
            //EmpleadoResponseDto empleadoResponseDto = _personaService.Buscar(rut);

            //EmpleadoResponseViewModel response = _mapper.Map<EmpleadoResponseViewModel>(empleadoResponseDto);

            //return Ok(response);
            return Ok();
        }

        [HttpGet]
        [Route("[action]/{rut}")]
        public async Task<IActionResult> Search(string rut)
        {
            //IActionResult response = BadRequest(new { message = ErrorMessage.RequestError });
            IActionResult response = BadRequest(new { message = "No se pudo realizar la consulta, ocurrio un error, consulte con su administrador." });

            var requestDto = new BusquedaPersonaRequestDto
            {
                rut = rut
            };
            var busquedaPersonaResponseDto = await _personaService.BuscarPersona(requestDto);


            if (busquedaPersonaResponseDto.Error == null)
            {
                var responseViewModel = _mapper.Map<BusquedaPersonaResponseViewModel>(busquedaPersonaResponseDto);
                response = Ok(responseViewModel);
            }

            return Ok(response);
        }
    }
}
