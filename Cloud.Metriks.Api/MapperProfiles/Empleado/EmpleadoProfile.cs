using AutoMapper;
using Cloud.Metriks.Api.Model.Dto.Empleado;
using Cloud.Metriks.Api.ViewModel.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Metriks.Api.MapperProfiles.Empleado
{
    public class EmpleadoProfile : Profile
    {
        public EmpleadoProfile()
        {
            #region MAPEO DTO A VIEWMODEL
            CreateMap<EmpleadoResponseDto, EmpleadoResponseViewModel>();
            #endregion
        }
    }
}
