using Cloud.Metriks.Api.Common.Error;

namespace Cloud.Metriks.Api.Model.Dto.Persona
{
    public class BusquedaPersonaResponseDto
    {
        public List<BusquedaPersonaDto> Result { get; set; }
        public ServiceException Error { get; set; }

    }
    public class BusquedaPersonaDto
    {
        public int Id { get; set; }
        public string RUT { get; set; }
        public string Nombre { get; set; }
    }
}
