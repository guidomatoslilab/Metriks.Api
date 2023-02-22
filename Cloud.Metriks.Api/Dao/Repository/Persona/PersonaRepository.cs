using Cloud.Metriks.Api.Dao.Context;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Model.Contract.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Dao.Repository.Persona
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ProgresoDbContext _context;

        public PersonaRepository(ProgresoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
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
