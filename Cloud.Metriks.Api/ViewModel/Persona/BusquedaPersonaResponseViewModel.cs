namespace Cloud.Metriks.Api.ViewModel.Persona
{
    public class BusquedaPersonaResponseViewModel
    {
        public List<BusquedaPersonaViewModel> Result { get; set; }
    }
    public class BusquedaPersonaViewModel
    {
        public int Id { get; set; }
        public string? RUT { get; set; }
        public string Nombre { get; set; }
    }
}
