using ApiPruebaTecnica.Modelo;

namespace ApiPruebaTecnica.Services
{
    public interface ITrabajadorService
    {
        Task<List<Trabajador>> ObtenerListadoTrabajadoresAsync();
        Task<List<Trabajador>?> GuardarListadoTrabajadoresAsync(List<Trabajador> listadoTrabajadores);
    }
}