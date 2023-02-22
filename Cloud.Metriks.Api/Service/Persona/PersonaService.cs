using AutoMapper;
using Cloud.Metriks.Api.Common.Error;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Interface.Service.Persona;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Dto.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Service.Persona
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public PersonaResponseDto Buscar(string rut)
        {
            PersonaResponseDto persona = _personaRepository.Buscar(rut);
            return persona;
        }

        public async Task<BusquedaPersonaResponseDto> BuscarPersona(BusquedaPersonaRequestDto requestDto)
        {
            BusquedaPersonaResponseDto response;
            try
            {
                response = await _personaRepository.SearchPersona(requestDto);
            }
            catch (Exception e)
            {
                response = new BusquedaPersonaResponseDto() { Error = new ServiceException(e.Message) };
            }

            return response;
        }
    }
}
