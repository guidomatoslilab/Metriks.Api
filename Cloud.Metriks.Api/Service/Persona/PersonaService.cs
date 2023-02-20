using AutoMapper;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Interface.Service.Persona;
using Cloud.Metriks.Api.Model.Contract.Persona;
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
        private readonly IMapper _mapper;

        public PersonaService(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
        }

        public PersonaResultContract Buscar(string rut)
        {
            PersonaEntity persona = _personaRepository.Buscar(rut);
            return _mapper.Map<PersonaResultContract>(persona);
        }
    }
}
