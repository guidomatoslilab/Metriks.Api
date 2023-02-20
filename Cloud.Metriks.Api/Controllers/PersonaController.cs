using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Interface.Service.Persona;
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

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }


        [HttpGet]
        [Route("[action]/{rut}")]
        public ActionResult Buscar(string rut)
        {
            var res = _personaService.Buscar(rut);
            return Ok(res);
        }
    }
}
