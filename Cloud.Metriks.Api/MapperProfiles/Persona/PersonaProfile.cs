using AutoMapper;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Dto.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
using Cloud.Metriks.Api.ViewModel.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.MapperProfiles.PersonaProfiles
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            #region MAPEO DTO A VIEWMODEL
            CreateMap<PersonaResponseDto,PersonaResponseViewModel>();
            CreateMap<BusquedaPersonaResponseDto, BusquedaPersonaResponseViewModel>();
            
            #endregion
        }
    }
}
