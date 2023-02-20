﻿using Cloud.Metriks.Api.Dao.Context;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Model.Entity.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.Dao.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ProgresoDbContext _context;

        public PersonaRepository(ProgresoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PersonaEntity Buscar(string rut)
        {
            PersonaEntity aux = _context.Persona.Where(b => b.prg_vch_rut.Equals(rut)).FirstOrDefault();
            return aux;
        }
    }
}
