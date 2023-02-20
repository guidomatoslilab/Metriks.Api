using AutoMapper;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
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
            CreateMap<PersonaEntity, PersonaResultContract>()
            .ForMember(x => x.Id, y => y.MapFrom(c =>
                c.prg_int_idpersona))
            .ForMember(x => x.RazonSocial, y => y.MapFrom(c => c.prg_vch_razonsocial));
        }
    }
}
