using Cloud.Metriks.Api.Dao.Commons;
using Cloud.Metriks.Api.Dao.Context;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Dto.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Dao.Repository.Persona
{
    public class PersonaRepository : BaseRepository<PersonaEntity>, IPersonaRepository
    {
        private readonly ProgresoDbContext _context;

        private readonly CommonRepository unitOfWork;

        //public PersonaRepository(ProgresoDbContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException(nameof(context));
        //}

        public PersonaRepository(ProgresoDbContext context) : base(context)
        {
            unitOfWork = new CommonRepository(context);
        }

        public async Task<PersonaEntity> AddPersona(PersonaEntity persona)
        {
            unitOfWork.Add(persona);
            await unitOfWork.SaveChangesAsync();

            return persona;
        }

        public async Task<PersonaEntity> UpdatePersona(PersonaEntity persona)
        {
            unitOfWork.Update(persona);
            await unitOfWork.SaveChangesAsync();

            return persona;
        }

        public async Task<BusquedaPersonaResponseDto> SearchPersona(BusquedaPersonaRequestDto requestDto)
        {
            var busquedaPersonaResponseDto = new BusquedaPersonaResponseDto();

            var query = (from per in context.Persona
                         where
                           (per.prg_vch_rut == requestDto.rut)
                         select new BusquedaPersonaDto
                         {
                             Id = per.prg_int_idpersona,
                             RUT = per.prg_vch_rut ?? "",
                             Nombre = per.prg_vch_nombre ?? ""
                         });

            var result = await unitOfWork.GetQuery(query);
            busquedaPersonaResponseDto.Result = result.ToList();

            return busquedaPersonaResponseDto;
        }

        public PersonaResponseDto Buscar(string rut)
        {
            PersonaResponseDto aux = _context.Persona.Where(b => b.prg_vch_rut.Equals(rut))
            .Select(s => new PersonaResponseDto()
            {
                Id = s.prg_int_idpersona,
                RazonSocial = s.prg_vch_razonsocial,
                RutEjecutivo = s.prg_vch_rut
            }).FirstOrDefault();
            return aux;
        }
    }
}
